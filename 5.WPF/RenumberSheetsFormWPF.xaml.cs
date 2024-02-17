// Importa as bibliotecas necessárias
using RevitEasy.WPF.Behaviors;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Diagnostics;
using System.Windows.Input;

// Namespace do seu código
namespace RevitEasy._5.WPF
{
    // Classe que representa o formulário de renumeração de folhas
    public partial class RenumberSheetsFormWPF : Window
    {
        private readonly Document doc;
        private List<ViewSheet> allSheets; // Propriedade para armazenar as folhas

        // Construtor da classe
        public RenumberSheetsFormWPF(Document document)
        {

            InitializeComponent();  // Inicializa os componentes do formulário
            doc = document;// Atribui o documento do Revit à propriedade
            RevitFormBehavior.Register(this);// Registra o formulário para comportamentos específicos do Revit
            Loaded += RenumberSheetsFormWPF_Loaded;// Adiciona um manipulador de eventos para o carregamento do formulário
        }

        // Manipulador de eventos ao carregar o formulário
        private void RenumberSheetsFormWPF_Loaded(object sender, RoutedEventArgs e)
        {
            // Carrega as folhas no ComboBox ao abrir o formulário
            LoadSheets();
        }

        // Método para obter todas as folhas no modelo
        private List<ViewSheet> GetAllSheets()
        {
            // Verifica se a lista de folhas já foi carregada, se sim, retorna a lista existente
            if (allSheets != null)
                return allSheets;

            // Caso contrário, cria um novo coletor de elementos filtrados
            allSheets = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_Sheets)
                .OfClass(typeof(ViewSheet))
                .Cast<ViewSheet>()
                .ToList();

            return allSheets;
        }

        #region Método para carregar as folhas nos ComboBoxes
        private void LoadSheets()
        {
            // Obtém todas as folhas do modelo
            List<ViewSheet> sheets = GetAllSheets();

            // Filtra folhas com números únicos
            HashSet<string> uniqueSheetNumbers = new HashSet<string>();

            // Ordena as folhas com base nos números
            sheets.Sort((sheet1, sheet2) =>
            {
                string sheetNumber1 = sheet1.get_Parameter(BuiltInParameter.SHEET_NUMBER)?.AsString();
                string sheetNumber2 = sheet2.get_Parameter(BuiltInParameter.SHEET_NUMBER)?.AsString();

                if (string.IsNullOrEmpty(sheetNumber1) || string.IsNullOrEmpty(sheetNumber2))
                    return 0;

                if (TryParseSheetNumber(sheetNumber1, out int num1) && TryParseSheetNumber(sheetNumber2, out int num2))
                {
                    // Comparação considerando parte numérica e textual
                    int numComparison = num1.CompareTo(num2);
                    return numComparison != 0 ? numComparison : sheetNumber1.CompareTo(sheetNumber2);
                }
                else
                {
                    // Trate o caso em que a conversão falha
                    return sheetNumber1.CompareTo(sheetNumber2);
                }
            });

            // Adiciona os números das folhas nos ComboBoxes (somente se únicos)
            foreach (var sheet in sheets)
            {
                string sheetNumber = sheet.get_Parameter(BuiltInParameter.SHEET_NUMBER)?.AsString();
                if (sheetNumber != null && uniqueSheetNumbers.Add(sheetNumber))
                {
                    Cb_StartSheet.Items.Add(sheetNumber);
                    Cb_EndSheet.Items.Add(sheetNumber);
                }
            }

        }
        #endregion

        #region Manipulador de eventos ao clicar no botão OK
        private void Btn_OK_Click(object sender, RoutedEventArgs e)
        {

            // Obtém os valores selecionados nos ComboBoxes e TextBoxes
            string selectedCb_StartSheet = Cb_StartSheet.SelectedItem?.ToString();
            string selectedCb_EndSheet = Cb_EndSheet.SelectedItem?.ToString();
            string prefixText = Tb_SheetNumberPreffix.Text;
            string startText = Tb_SheetNumberStart.Text;

            // Verifica se algum dos campos obrigatórios está vazio
            if (string.IsNullOrEmpty(selectedCb_StartSheet) || string.IsNullOrEmpty(selectedCb_EndSheet) || string.IsNullOrEmpty(startText))
            {
                // Mostra uma mensagem de aviso se algum campo estiver vazio
                TaskDialog.Show("Fields Empty", "One or more fields are empty or not filled in correctly");
            }
            else
            {
                // Converte os valores para números inteiros
                if (TryParseSheetNumber(selectedCb_StartSheet, out int startNumber) &&
                    TryParseSheetNumber(selectedCb_EndSheet, out int endNumber) &&
                    TryParseSheetNumber(startText, out int starts))
                {
                    // Filtra as folhas no intervalo selecionado
                    List<ViewSheet> sheetsToRenumber = allSheets
                        .Where(sheet =>
                        {
                            string sheetNumber = sheet.get_Parameter(BuiltInParameter.SHEET_NUMBER)?.AsString();
                            return TryParseSheetNumber(sheetNumber, out int sheetNum) && sheetNum >= startNumber && sheetNum <= endNumber;
                        })
                        .OrderBy(sheet => sheet.get_Parameter(BuiltInParameter.SHEET_NUMBER)?.AsString())
                        .ToList();

                    // Inicia uma transação para renumerar as folhas
                    using (Transaction sheetTrans = new Transaction(doc, "Renumber Sheets"))
                    {
                        try
                        {
                            // Inicia a transação
                            sheetTrans.Start();

                            // Itera sobre o intervalo de folhas e renumera cada uma
                            foreach (ViewSheet sheet in sheetsToRenumber)
                            {
                                if (sheet != null)
                                {
                                    // Obtém o número da folha antes de qualquer modificação
                                    string sheetNumber = sheet.get_Parameter(BuiltInParameter.SHEET_NUMBER)?.AsString();

                                    // Calcula o novo número da folha
                                    int newSheetNum = starts++;

                                    // Formata o número da folha
                                    string formattedSheetNumber = string.IsNullOrEmpty(prefixText)
                                        ? newSheetNum.ToString()  // Sem prefixo se estiver vazio
                                        : $"{prefixText}{newSheetNum}";

                                    // Atualiza o número da folha no Revit
                                    sheet.get_Parameter(BuiltInParameter.SHEET_NUMBER)?.Set(formattedSheetNumber);
                                }
                            }

                            // Completa a transação
                            sheetTrans.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Cancela a transação
                            sheetTrans.RollBack();
                        }
                    }
                }

            }

        }

        private bool TryParseSheetNumber(string sheetNumber, out int number)
        {
            // Extrai a parte numérica da string (se existir) e converte para um número
            string numericPart = new string(sheetNumber.Where(char.IsDigit).ToArray());

            return int.TryParse(numericPart, out number);
        }

        #endregion

        // Manipulador de eventos ao clicar no botão Cancel
        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Fecha o formulário
            Close();
        }

        // Manipulador de eventos para quando um RadioButton é marcado
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Adicione lógica específica para quando um RadioButton é marcado
        }

        private bool IsNumericKey(Key key)
        {
            // Verifica se o código da tecla está na faixa numérica, incluindo Tab e números do teclado numérico à direita
            return ((key >= Key.D0 && key <= Key.D9) || (key >= Key.NumPad0 && key <= Key.NumPad9)) || key == Key.Tab;
        }

        // Manipulador de eventos para a tecla PreviewKeyDown no TextBox Tb_SheetNumberStart
        private void Tb_SheetNumberStart_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            // Verifica se a tecla pressionada é um número ou a tecla "Backspace"
            if (!IsNumericKey(e.Key) && e.Key != Key.Back)
            {
                e.Handled = true; // Ignora a tecla pressionada
                System.Windows.MessageBox.Show("Digite apenas números inteiros");
            }
        }
    }
}
