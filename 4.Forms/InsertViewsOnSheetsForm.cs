using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using View = Autodesk.Revit.DB.View;

namespace RevitEasy.InsertViewsOnSheetForm.forms
{
    public partial class Form_InsertViewsOnSheets : System.Windows.Forms.Form
    {
        private readonly Document doc;
        private SheetCollector sheetCollector; // Adiciona essa linha
        private string selectedParameterName;

        public Form_InsertViewsOnSheets(Document document)
        {
            InitializeComponent();


            doc = document;
            sheetCollector = new SheetCollector(doc); // Inicializa o coletor de folhas
        }

        #region Ação que é executada ao abrir o formulário Form_InsertViewsOnSheets_Load
        private void Form_InsertViewsOnSheets_Load(object sender, EventArgs e)
        {
            // Carrega os ViewTypes no combobox
            LoadViewTypes();

            //Carrega as folhas disponíveis no modelo
            GetSheetsAndPerformOperation();

            // Obtém a lista de parâmetros de instância das folhas
            List<string> instanceParametersForSheets = sheetCollector.GetInstanceParametersForSheets();

            // Insere a lista de parâmetros de instância das folhas no combobox
            Cb_InsertViewOnSheetsViewParametersForSheet.DataSource = instanceParametersForSheets;
        }

        #endregion

        #region Métodos para receber os inputs do formulário e inserir vistas nas folhas Click_InsertViewOnSheetsEvent()
        // Método chamado quando o botão de criação é clicado
        private void Click_InsertViewOnSheetsEvent(object sender, EventArgs e)
        {
            // Verifique se a variável de instância selectedParameterName já foi inicializada
            if (string.IsNullOrEmpty(selectedParameterName))
            {
                TaskDialog.Show("Erro", "Selecione um parâmetro antes de continuar.");
                return;
            }

            // Obtém o valor inserido no combobox que será usado com filtro e converte em texto
            string filterValue = Cb_InsertViewsOnSheetFilterForViewsValue.Text.Trim();

            // Verifica se tanto o parâmetro quanto o valor não estão vazios
            if (!string.IsNullOrEmpty(filterValue))
            {
                // Obtém todas as vistas do modelo
                IEnumerable<Autodesk.Revit.DB.View> allViews = new FilteredElementCollector(doc)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>();

                // Lista para armazenar as vistas filtradas
                List<Autodesk.Revit.DB.View> filteredViews = new List<Autodesk.Revit.DB.View>();

                // Itera sobre as vistas e verifica se atendem às condições de filtragem
                foreach (Autodesk.Revit.DB.View view in allViews)
                {
                    // Obtém o parâmetro selecionado da vista
                    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
                        .FirstOrDefault(p => p.Definition.Name == selectedParameterName);

                    // Verifica se o parâmetro existe e se o valor é igual ao valor inserido no TextBox
                    if (selectedParameter != null && selectedParameter.AsString() == filterValue)
                    {
                        // Adiciona a vista à lista de vistas filtradas
                        filteredViews.Add(view);
                    }
                }

                // Inserir as vistas nas folhas
                InsertViewsOnSheets(filteredViews);
            }
        }
        #endregion

        #region Método responsavel por obter as folhas disponíveis no modelo LoadSheets()
        private void GetSheetsAndPerformOperation()
        {
            // Verifique se a variável de instância selectedParameterName já foi inicializada
            if (string.IsNullOrEmpty(selectedParameterName))
            {
                TaskDialog.Show("Erro", "Selecione um parâmetro antes de continuar.");
                return;
            }

            // Obtém o valor inserido no combobox que será usado com filtro e converte em texto
            string filterValue = Cb_InsertViewsOnSheetFilterForViewsValue.Text.Trim();

            // Verifica se tanto o parâmetro quanto o valor não estão vazios
            if (!string.IsNullOrEmpty(filterValue))
            {
                // Obtém todas as folhas do modelo
                SheetCollector sheetCollector = new SheetCollector(doc);
                IEnumerable<ViewSheet> allSheets = sheetCollector.GetAllSheets();

                // Lista para armazenar as folhas filtradas
                List<ViewSheet> filteredSheets = new List<ViewSheet>();

                // Itera sobre as folhas e verifica se atendem às condições de filtragem
                foreach (ViewSheet sheet in allSheets)
                {
                    // Obtém o parâmetro selecionado da folha (ajuste conforme necessário)
                    Parameter selectedParameter = sheet.LookupParameter(selectedParameterName);

                    // Verifica se o parâmetro existe e se o valor é igual ao valor inserido no TextBox
                    if (selectedParameter != null && selectedParameter.AsString() == filterValue)
                    {
                        // Adiciona a folha à lista de folhas filtradas
                        filteredSheets.Add(sheet);
                    }
                }

                // Execute a operação desejada com as folhas filtradas (ajuste conforme necessário)
                ProcessFilteredSheets(filteredSheets);

                //Insere no combobox Cb_InsertViewOnSheetsViewParametersForSheet os parametros de instância disponíveis para serem selecionados
                Cb_InsertViewOnSheetsViewParametersForSheet.DataSource = filteredSheets;
            }
        }

        #region Método para processar as folhas filtradas
        private void ProcessFilteredSheets(List<ViewSheet> filteredSheets)
        {
            //Filtra as vistas com base no parametro selecionado no combobox Cb_InsertViewOnSheetsViewParametersForSheet
            string selectedParameterName = Cb_InsertViewOnSheetsViewParametersForSheet.SelectedItem?.ToString();

            // Verifica se o parâmetro não está vazio
            if (!string.IsNullOrEmpty(selectedParameterName))
            {
                // Obtém todas as vistas do modelo
                IEnumerable<Autodesk.Revit.DB.View> allViews = new FilteredElementCollector(doc)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>();

                // Lista para armazenar as vistas filtradas
                List<Autodesk.Revit.DB.View> filteredViews = new List<Autodesk.Revit.DB.View>();

                // Itera sobre as vistas e verifica se atendem às condições de filtragem
                foreach (Autodesk.Revit.DB.View view in allViews)
                {
                    // Obtém o parâmetro selecionado da vista
                    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
                        .FirstOrDefault(p => p.Definition.Name == selectedParameterName);

                    // Verifica se o parâmetro existe e se o valor é igual ao valor inserido no TextBox
                    if (selectedParameter != null && selectedParameter.AsString() == selectedParameterName)
                    {
                        // Adiciona a vista à lista de vistas filtradas
                        filteredViews.Add(view);
                    }
                }

                // Inserir as vistas nas folhas
                InsertViewsOnSheets(filteredViews);
            }



            // Contagem de folhas filtradas 
            int filteredSheetsCount = filteredSheets.Count;

            //Insere a quantidade de folhas filtradas no Label Lb_InsertViewOnSheetsSelectedSheetsCount
            Lb_InsertViewOnSheetsSelectedSheetsCount.Text = filteredSheetsCount.ToString();



            // Esta função precisa ser implementada conforme a lógica específica do seu aplicativo
            // A estrutura básica seria algo como: 
            // foreach (var sheet in filteredSheets)
            // {
            //     // Lógica para trabalhar com a folha
            // }
        }
        #endregion
        #endregion

        #region Método para obter as vistas disponíveis  LoadInstanceParametersInSelectView()
        // No modelo filtrando pela viewType que foi selecionada no combobox Cb_InsertViewOnSheetsViewTypeViews 
        // e logo em seguida, obtendo os parâmetros de instância do modelo e colocando-os no combobox
        private void LoadInstanceParametersInSelectView()
        {
            // Obtém o ViewType que foi selecionado no combobox Cb_InsertViewOnSheetsViewTypeViews
            string selectedViewsType = Cb_InsertViewOnSheetsViewTypeViews.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedViewsType))
            {
                // Lidar com a situação em que nenhum tipo de vista foi selecionado
                return;
            }

            // Obtém todos os tipos de Views no modelo
            IEnumerable<ViewFamilyType> viewTypes = new FilteredElementCollector(doc)
                .OfClass(typeof(ViewFamilyType))
                .Cast<ViewFamilyType>();

            // Encontra Vistas correspondentes ao viewType 
            ViewFamilyType targetViewType = viewTypes.FirstOrDefault(vt => vt.Name == selectedViewsType);

            if (targetViewType != null)
            {
                // Obtém todas as vistas do tipo desejado
                IEnumerable<Autodesk.Revit.DB.View> views = new FilteredElementCollector(doc)
                    .OfCategory(BuiltInCategory.OST_Views)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>()
                    .Where(v => v.GetTypeId().IntegerValue == targetViewType.Id.IntegerValue);

                // Lista para armazenar nomes dos parâmetros de instância
                List<string> instanceParametersList = new List<string>();

                // Itera sobre as vistas e obtém os parâmetros de instância
                foreach (Autodesk.Revit.DB.View view in views)
                {
                    // Obtém todos os parâmetros de instância da vista
                    IEnumerable<Autodesk.Revit.DB.Parameter> instanceParameters = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>();

                    // Adiciona os nomes dos parâmetros à lista
                    instanceParametersList.AddRange(instanceParameters.Select(parameter => parameter.Definition.Name));
                }

                // Insere no combobox os parâmetros de instância disponíveis para serem selecionados
                Cb_InsertViewOnSheetsViewParametersForView.DataSource = instanceParametersList;
            }
        }
        #endregion

        #region Método para inserir as vistas nas folhas  InsertViewsOnSheets()
        private void InsertViewsOnSheets(List<Autodesk.Revit.DB.View> filteredViews)
        {
            // Obtém todas as vistas do modelo
            IEnumerable<View> allViews = new FilteredElementCollector(doc).OfClass(typeof(View)).Cast<View>();

            // Lista para armazenar as vistas selecionadas
            List<View> selectedViews = new List<View>();

            //// Itera sobre as vistas e verifica se atendem às condições de filtragem
            //foreach (View view in allViews)
            //{
            //    // Obtém o parâmetro selecionado da vista
            //    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
            //        .FirstOrDefault(p => p.Definition.Name == selectedParameterName);

            //    // Verifica se o parâmetro existe e se o valor é igual ao valor selecionado no ComboBox
            //    if (selectedParameter != null && selectedParameter.AsString() == selectedFilterValue)
            //    {
            //        // Adiciona a vista à lista de vistas selecionadas
            //        selectedViews.Add(view);
            //    }
            //}
            //// Insere as vistas selecionadas nas folhas
            //foreach (View view in selectedViews)
            //{
            //    // Obtém a folha selecionada
            //    ViewSheet sheet = (ViewSheet)view.Document.ActiveView.ViewSheet;

            //    // Insere a vista na folha
            //    sheet.InsertView(view);
            //}


        }
        #endregion

        #region Evento que é executado sempre que o Tipo de vista é selecionado no combobox Cb_InsertViewOnSheetsViewTypeViews Sic_InsertViewOnSheetsViewTypeViews
        private void Sic_InsertViewOnSheetsViewTypeViews(object sender, EventArgs e)
        {
            // Aqui se carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType que foi selecionado no combobox Cb_InsertViewOnSheetsViewTypeViews
            LoadInstanceParametersInSelectView();
        }
        #endregion

        #region Método que verifica quais os ViewTypes estão disponíveis no modelo LoadViewTypes()
        // Método para carregar os ViewTypes no ComboBox Cb_InsertViewOnSheetsViewTypeViews
        private void LoadViewTypes()
        {
            try
            {
                // Obtém todos os tipos de Views no modelo
                IList<ViewFamilyType> viewTypes = new FilteredElementCollector(doc)
                    .OfClass(typeof(ViewFamilyType))
                    .Cast<ViewFamilyType>()
                    .ToList();

                // Obtém os nomes dos View Types
                IList<string> viewTypesName = viewTypes.Select(t => t.Name).ToList();

                // Atualiza o ComboBox apenas se não estiver vazio
                if (viewTypesName.Count > 0)
                {
                    Cb_InsertViewOnSheetsViewTypeViews.DataSource = viewTypesName;
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Erro", "Ocorreu um erro ao carregar os tipos de visualização: " + ex.Message);
            }
        }
        #endregion 

        #region Método para obter vistas, obter parâmetros, agrupá-los em lista, e colocar no combobox
        private void Sic_InsertViewOnSheetsViewParametersForView(object sender, EventArgs e)
        {
            // Verifica se há um parâmetro selecionado no combobox
            selectedParameterName = Cb_InsertViewOnSheetsViewParametersForView.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedParameterName))
            {
                // Obtém todas as vistas do modelo
                IEnumerable<Autodesk.Revit.DB.View> allViews = new FilteredElementCollector(doc)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>();

                // Lista para armazenar os valores possíveis para o filtro
                HashSet<string> filterValues = new HashSet<string>();

                // Itera sobre as vistas e verifica os valores do parâmetro selecionado
                foreach (Autodesk.Revit.DB.View view in allViews)
                {
                    // Obtém o parâmetro selecionado da vista
                    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
                        .FirstOrDefault(p => p.Definition.Name == selectedParameterName);

                    // Adiciona o valor à lista, se existir e não for nulo ou vazio
                    if (selectedParameter != null)
                    {
                        string parameterValue = selectedParameter.AsString();
                        if (!string.IsNullOrEmpty(parameterValue))
                        {
                            filterValues.Add(parameterValue);
                        }
                    }
                }

                // Limpa os itens atuais do combobox
                Cb_InsertViewsOnSheetFilterForViewsValue.Items.Clear();

                // Adiciona os valores distintos diretamente ao combobox, se a lista não for vazia
                if (filterValues.Any())
                {
                    // Adiciona os valores apenas se houver itens
                    foreach (var value in filterValues)
                    {
                        Cb_InsertViewsOnSheetFilterForViewsValue.Items.Add(value);
                    }
                }

                // Mensagem de depuração
                Console.WriteLine("Cb_InsertViewsOnSheetFilterForViewsValue.DataSource atualizado com sucesso.");
                Console.WriteLine("Valores distintos no filtro: " + string.Join(", ", filterValues));
            }
        }

        #endregion

        #region Ação executada sempre que o usuário seleciona um valor no combobox Sic_InsertViewsOnSheetFilterForViewsValue 
        private void Sic_InsertViewsOnSheetFilterForViewsValue(object sender, EventArgs e)
        {
            // Obtém o valor selecionado no ComboBox
            string selectedFilterValue = Cb_InsertViewsOnSheetFilterForViewsValue.SelectedItem?.ToString();

            // Verifica se o valor não está vazio
            if (!string.IsNullOrEmpty(selectedFilterValue))
            {
                // Obtém todas as vistas do modelo
                IEnumerable<Autodesk.Revit.DB.View> allViews = new FilteredElementCollector(doc)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>();

                // Contador para armazenar a quantidade de vistas filtradas
                int filteredViewsCount = 0;

                // Itera sobre as vistas e verifica se atendem às condições de filtragem
                foreach (Autodesk.Revit.DB.View view in allViews)
                {
                    // Obtém o parâmetro selecionado da vista
                    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
                        .FirstOrDefault(p => p.Definition.Name == selectedParameterName);

                    // Verifica se o parâmetro existe e se o valor é igual ao valor selecionado no ComboBox
                    if (selectedParameter != null && selectedParameter.AsString() == selectedFilterValue)
                    {
                        // Incrementa o contador de vistas filtradas
                        filteredViewsCount++;
                    }
                }

                // Exibe a quantidade de vistas filtradas no Label
                Lb_InsertViewOnSheetsSelectedViewsCount.Text = filteredViewsCount.ToString();
            }
            else
            {
                // Se o valor selecionado no ComboBox for vazio, exibe 0 no Label
                Lb_InsertViewOnSheetsSelectedViewsCount.Text = "0";
            }
        }
        #endregion


        #region Ação executada sempre que o usuário seleciona um parametro no comboboxCb_InsertViewOnSheetsViewParametersForSheet 


        private void Cb_InsertViewOnSheetsViewParametersForSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa os itens atuais do combobox
            Cb_InsertViewsOnSheetFilterForSheetsValue.Items.Clear();

            // Obtém o parâmetro de instância selecionado no combobox
            selectedParameterName = Cb_InsertViewOnSheetsViewParametersForSheet.SelectedItem?.ToString();

            // Verifica se o parâmetro não está vazio
            if (!string.IsNullOrEmpty(selectedParameterName))
            {
                // Obtém todas as folhas do modelo
                SheetCollector sheetCollector = new SheetCollector(doc);
                IEnumerable<ViewSheet> allSheets = sheetCollector.GetAllSheets();

                // Lista para armazenar os valores possíveis para o filtro
                HashSet<string> filterValues = new HashSet<string>();

                // Itera sobre as folhas e verifica os valores do parâmetro selecionado
                foreach (ViewSheet sheet in allSheets)
                {
                    // Obtém o parâmetro selecionado da folha
                    Parameter selectedParameter = sheet.LookupParameter(selectedParameterName);

                    // Adiciona o valor à lista, se existir e não for nulo ou vazio
                    if (selectedParameter != null)
                    {
                        string parameterValue = selectedParameter.AsString();
                        if (!string.IsNullOrEmpty(parameterValue))
                        {
                            filterValues.Add(parameterValue);
                        }
                    }
                }

                // Adiciona os valores distintos diretamente ao combobox, se a lista não for vazia
                if (filterValues.Any())
                {
                    foreach (var value in filterValues)
                    {
                        Cb_InsertViewsOnSheetFilterForSheetsValue.Items.Add(value);
                    }
                }

                // Mensagem de depuração
                Console.WriteLine("Cb_InsertViewsOnSheetFilterForSheetsValue.DataSource atualizado com sucesso.");
                Console.WriteLine("Valores distintos no filtro: " + string.Join(", ", filterValues));
            }
        }

        private void Sic_InsertViewsOnSheetFilterForSheetsValue(object sender, EventArgs e)
        {
            // Obtém o valor selecionado no ComboBox
            string selectedFilterValue = Cb_InsertViewsOnSheetFilterForSheetsValue.SelectedItem?.ToString();

            // Verifica se o valor não está vazio
            if (!string.IsNullOrEmpty(selectedFilterValue))
            {
                // Obtém todas as vistas do modelo
                IEnumerable<Autodesk.Revit.DB.View> allViews = new FilteredElementCollector(doc)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>();

                // Contador para armazenar a quantidade de vistas filtradas
                int filteredViewsCount = 0;

                // Itera sobre as vistas e verifica se atendem às condições de filtragem
                foreach (Autodesk.Revit.DB.View view in allViews)
                {
                    // Obtém o parâmetro selecionado da vista
                    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
                        .FirstOrDefault(p => p.Definition.Name == selectedParameterName);

                    // Verifica se o parâmetro existe e se o valor é igual ao valor selecionado no ComboBox
                    if (selectedParameter != null && selectedParameter.AsString() == selectedFilterValue)
                    {
                        // Incrementa o contador de vistas filtradas
                        filteredViewsCount++;
                    }
                }

                // Exibe a quantidade de vistas filtradas no Label
                Lb_InsertViewOnSheetsSelectedSheetsCount.Text = filteredViewsCount.ToString();
            }
            else
            {
                // Se o valor selecionado no ComboBox for vazio, exibe 0 no Label
                Lb_InsertViewOnSheetsSelectedSheetsCount.Text = "0";
            }
        }



        #endregion

        #region Método para obter as folhas disponíveis no modelo
        internal class SheetCollector
        {
            private readonly Document document;

            public SheetCollector(Document document)
            {
                this.document = document;
            }

            public IEnumerable<ViewSheet> GetAllSheets()
            {
                return new FilteredElementCollector(document)
                    .OfClass(typeof(ViewSheet))
                    .Cast<ViewSheet>();
            }
            // Método para obter os parâmetros de instância das folhas
            public List<string> GetInstanceParametersForSheets()
            {
                // Obtém todas as folhas do modelo
                IEnumerable<ViewSheet> allSheets = GetAllSheets();

                // Lista para armazenar nomes dos parâmetros de instância das folhas
                List<string> instanceParametersList = new List<string>();

                // Itera sobre as folhas e obtém os parâmetros de instância
                foreach (ViewSheet sheet in allSheets)
                {
                    // Obtém todos os parâmetros de instância da folha
                    IEnumerable<Parameter> instanceParameters = sheet.Parameters.Cast<Parameter>();

                    // Itera sobre os parâmetros de instância e obtém os nomes
                    foreach (Parameter parameter in instanceParameters)
                    {
                        instanceParametersList.Add(parameter.Definition.Name);
                    }
                }

                // Retorna a lista de nomes dos parâmetros de instância das folhas
                return instanceParametersList;
            }
        }


        #endregion

        private void Lb_InsertViewOnSheetsSelectedViewsCount_Click(object sender, EventArgs e)
        {

        }

        private void Lb_InsertViewOnSheetsSelectedSheetsCount_Click(object sender, EventArgs e)
        {

        }
    }
}
