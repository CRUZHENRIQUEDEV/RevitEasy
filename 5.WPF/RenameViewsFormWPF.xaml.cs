using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.UI;

namespace RevitEasy._5.WPF
{
    public partial class RenameViewsFormWPF : Window
    {
        private readonly Document doc;

        // Construtor do formulário
        public RenameViewsFormWPF(Document document)
        {
            InitializeComponent();
            doc = document; // Inicializa o documento
    }

        #region Ação que é executada ao abrir o formulário
        private void WPF_RenameViews_Loaded(object sender, RoutedEventArgs e)
        {
            // Adicione o evento ao combobox Cb_RenameViewsInstanceParameters aqui
            Cb_RenameViewsInstanceParameters.SelectedIndex += Cb_RenameViewsInstanceParameters_SelectedIndexChanged;

            // Carrega os ViewTypes no combobox
            LoadViewTypes();

            // Carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType que foi selecionado no combobox Cb_RenameViewsType
            LoadInstanceParametersInSelectView();
        }

        #endregion

        #region Métodos para receber os inputs do formulário e criar as folhas
        // Método chamado quando o botão de criação é clicado
        private void Btn_RenameViews_Click(object sender, RoutedEventArgs e)
        {
            // Obtém o nome do parâmetro de instancia que será usado para filtrar as vistas selecionado no combobox
            string selectedParameterName = Cb_RenameViewsInstanceParameters.SelectedItem?.ToString();

            // Obtém o valor inserido no combobox que será usado com filtro e converte em texto
            string filterValue = Cb_RenameViewsFilterValue.Text.Trim();

            // Verifica se tanto o parâmetro quanto o valor não estão vazios
            if (!string.IsNullOrEmpty(selectedParameterName) && !string.IsNullOrEmpty(filterValue))
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

                // Renomear todas as vistas

                // Obtém o número inicial para os novos nomes
                int starts = int.Parse(Tb_RenameViewNameNumberStarts.Text);

                // Itera sobre as vistas para renomear
                for (int i = 0; i < filteredViews.Count; i++)
                {
                    // Formata o número para o nome da vista
                    string formattedViewNumberForName = (starts + i).ToString("D2");

                    // Método para renomear as vistas
                    RenameViews(filteredViews[i], formattedViewNumberForName);
                }
            }
            else
            {
                // Lidar com a situação em que o parâmetro ou o valor estão vazios
                MessageBox.Show("Por favor, selecione um parâmetro e insira um valor para filtrar as vistas.");
            }
        }

        #endregion

        #region Método para obter as vistas disponíveis no modelo filtrando pela viewType que foi selecionada no combobox Cb_RenameViewsType e, em seguida, obtendo os parâmetros de instância do modelo e colocando-os no combobox
        // Método para obter as vistas disponíveis no modelo filtrando pelo ViewType que foi selecionado no combobox Cb_RenameViewsType e, em seguida, obtendo os parâmetros de instância do modelo e colocando-os no combobox
        private void LoadInstanceParametersInSelectView()
        {
            // Obtém o ViewType que foi selecionado no combobox Cb_RenameViewsType
            string selectedViewsType = Cb_RenameViewsType.SelectedValue as string;

            if (string.IsNullOrEmpty(selectedViewsType))
            {
                // Lidar com a situação em que nenhum tipo de vista foi selecionado
                return;
            }

            // Obtém todos os tipos de Views no modelo
            IEnumerable<ViewFamilyType> viewTypes = new FilteredElementCollector(doc)
                .OfClass(typeof(ViewFamilyType))
                .Cast<ViewFamilyType>();

            // Encontra Vistas correspondentes ao ViewType
            ViewFamilyType targetViewType = viewTypes.FirstOrDefault(vt => vt.ViewFamily.ToString() == selectedViewsType);

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
                Cb_RenameViewsInstanceParameters.ItemsSource = instanceParametersList.Distinct().ToList();

                // Atualiza o ComboBox Cb_RenameViewsFilterValue com os valores únicos dos parâmetros de instância
                Cb_RenameViewsFilterValue.ItemsSource = instanceParametersList.Distinct().ToList();
            }
        }



        #endregion



        #region Método para renomear a vistas
        // Método para renomear as vistas
        private void RenameViews(Autodesk.Revit.DB.View view, string formattedViewNumberForName)
        {
            // Inicia uma transação para a renomeação da vista
            using (Transaction trans = new Transaction(doc, "Renomear Vista"))
            {
                trans.Start();

                try
                {
                    // Obtém o prefixo e sufixo para o nome da vista inseridos pelo usuário
                    string prefix = RenameViewNamePreffix.Trim();
                    string suffix = RenameViewNameSuffix.Trim();

                    // Constrói o novo nome da vista
                    string newName = prefix + formattedViewNumberForName + suffix;

                    // Define o novo nome para a vista
                    view.Name = newName;

                    // Confirma a transação
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    // Em caso de erro, cancela a transação
                    trans.RollBack();
                    TaskDialog.Show("Erro", "Ocorreu um erro ao renomear a vista: " + ex.Message);
                }
            }
        }
        #endregion

        #region Evento que é executado sempre que o Tipo de vista é selecionado no combobox Cb_RenameViewsType
        // Evento que é executado sempre que o Tipo de vista é selecionado no combobox Cb_RenameViewsType
        private void Cb_RenameViewsType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType que foi selecionado no combobox Cb_RenameViewsType
            LoadInstanceParametersInSelectView();
        }
        #endregion


        #region Método que verifica quais os ViewTypes estão disponíveis no modelo, não alterar nada aqui, já está funcionando corretamente
        // Método para carregar os ViewTypes no ComboBox Cb_RenameViewsType
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
                IList<string> viewTypesName = viewTypes.Select(t => t.ViewFamily.ToString()).ToList();

                // Atualiza o ComboBox apenas se não estiver vazio
                if (viewTypesName.Count > 0)
                {
                    Cb_RenameViewsType.ItemsSource = viewTypesName;
                    Cb_RenameViewsType.SelectedIndex = 0; // Defina o primeiro item como selecionado por padrão
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Erro", "Ocorreu um erro ao carregar os tipos de visualização: " + ex.Message);
            }
        }

        #endregion


        #region Métodos para converter os valores dos inputs do usuário em texto
        // Métodos para converter os valores dos inputs do usuário em texto
        public string RenameViewsFilterValue => Cb_RenameViewsFilterValue.Text;
        public string RenameViewNamePreffix => Tb_RenameViewNamePreffix.Text;
        public string RenameViewNameSuffix => Tb_RenameViewNameSuffix.Text;
        public int Cb_RenameViewsInstanceParameters_SelectedIndexChanged { get; private set; }
        #endregion


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cb_Tb_RenameViewsPreffixName(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cb_RenameViewsPreffixName(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cb_RenameViewsPreffixNameSelectionChanded(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cb_RenameViewsFilterParameter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cb_RenameViewsPreffixName_SelectionChanded(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Tb_RenameViewsPreffixName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cb_RenameViewsInstanceParameters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Tb_RenameViewNamePreffix_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void Btn_RenameViewsExit_Click(object sender, RoutedEventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }

    }
}
