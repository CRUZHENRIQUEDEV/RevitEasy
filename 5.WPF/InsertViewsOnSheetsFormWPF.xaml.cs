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
using RevitEasy.LoadViewTypes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Threading;


namespace RevitEasy.InsertViewsOnSheetsWPF
{
    public partial class InsertViewsOnSheetsFormWPF : Window
    {
        private readonly Document doc;
        private ObservableCollection<string> filterValues;
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ViewTypeManager viewTypeManager;

        public ObservableCollection<string> FilterValues
        {
            get { return filterValues; }
            set
            {
                filterValues = value;
                OnPropertyChanged(nameof(FilterValues));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public InsertViewsOnSheetsFormWPF(Document document)
        {
            InitializeComponent();
            doc = document; // Inicializa o documento
            viewTypeManager = new ViewTypeManager(doc); // Adiciona a instância do ViewTypeManager                                            
            FilterValues = new ObservableCollection<string>(); // Inicializa a coleção
        }

        #region Ação que é executada ao abrir o formulário 
        private void InsertViewsOnSheetsFormWPF_Loaded(object sender, RoutedEventArgs e)
        {
            // Configura a cultura com base nas preferências do usuário ou do sistema
            CultureInfo newCulture = new CultureInfo("pt-BR");  // Use "en-US" para inglês
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            // Atualizar os componentes visuais se necessário
            UpdateUIForCultureChange();

            // Adicione o evento ao combobox Cb_RenameViewsInstanceParameters 
            Cb_InsertViewOnSheetsViewViewType.SelectionChanged += Cb_InsertViewOnSheetsViewViewType_SelectionChanged;

            // Carrega os ViewTypes no combobox usando a instância viewTypeManager
            LoadViewTypes();

            // Carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType que foi selecionado no combobox Cb_RenameViewsType
            LoadInstanceParametersInSelectView();
        }
        #endregion

        #region Acão executada quando o botão sair é clicado
        private void Btn_RenameViewsExit_Click(object sender, RoutedEventArgs e)
        {
            //Acão executada quando o botão sair é clicado

            // Fecha o formulário
            this.Close();
        }
        #endregion

        #region Método que verifica quais os ViewTypes estão disponíveis no modelo, LoadViewTypes
        // Método para carregar os ViewTypes no ComboBox Cb_RenameViewsType
        private void LoadViewTypes()
        {
            
           // Obtém todos os tipos de Views no modelo usando a instância viewTypeManager
           IList<string> viewTypesName = viewTypeManager.GetViewTypes();

           // Atualiza o ComboBox apenas se não estiver vazio
            if (viewTypesName.Count > 0)
             {
                Cb_InsertViewOnSheetsViewViewType.ItemsSource = viewTypesName;
                Cb_InsertViewOnSheetsViewViewType.SelectedIndex = 0; // Define o primeiro item como selecionado por padrão
             }
        }

        #endregion

        #region Método para obter as vistas disponíveis no modelo filtrando pela viewType que foi selecionada no combobox Cb_RenameViewsType -LoadInstanceParametersInSelectView

        // Dicionário para armazenar os parâmetros de instância associados ao tipo de vista selecionado
        private Dictionary<string, List<string>> instanceParametersByViewType = new Dictionary<string, List<string>>();

        // Método para obter as vistas disponíveis no modelo e associar os parâmetros de instância ao tipo de vista
        private void LoadInstanceParametersInSelectView()
        {
            // Obtém o ViewType que foi selecionado no combobox Cb_RenameViewsType
            string selectedViewsType = Cb_InsertViewOnSheetsViewViewType.SelectedValue as string;

            if (string.IsNullOrEmpty(selectedViewsType))
            {
                // Lidar com a situação em que nenhum tipo de vista foi selecionado
                return;
            }

            // Obtém os parâmetros de instância usando a instância viewTypeManager
            IList<string> instanceParametersList = viewTypeManager.GetInstanceParametersForViewType(selectedViewsType);

            // Armazena os parâmetros de instância associados ao tipo de vista
            instanceParametersByViewType[selectedViewsType] = instanceParametersList.Distinct().ToList();

            // Insere no combobox os parâmetros de instância disponíveis para serem selecionados
            Cb_InsertViewOnSheetsViewParametersForView.ItemsSource = instanceParametersList.Distinct().ToList();

            // Atualiza o ComboBox Cb_RenameViewsFilterValue com os valores únicos dos parâmetros de instância
            Cb_InsertViewsOnSheetFilterForViewsValue.ItemsSource = instanceParametersList.Distinct().ToList();
        }
        #endregion



        private void Cb_InsertViewOnSheetsViewViewType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType que foi selecionado no combobox Cb_InsertViewOnSheetsViewViewType
            LoadInstanceParametersInSelectView();

        }

        #region Evento que é executado sempre que o Parâmetro de instância é selecionado no combobox Cb_RenameViewsInstanceParameters -Cb_RenameViewsInstanceParameters_SelectionChanged
        private void Cb_InsertViewOnSheetsViewParametersForView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedParameterName = Cb_InsertViewOnSheetsViewParametersForView.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedParameterName))
            {
                IEnumerable<Autodesk.Revit.DB.View> allViews = new FilteredElementCollector(doc)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>();

                HashSet<string> distinctValues = new HashSet<string>();

                foreach (Autodesk.Revit.DB.View view in allViews)
                {
                    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
                        .FirstOrDefault(p => p.Definition.Name == selectedParameterName);

                    if (selectedParameter != null)
                    {
                        string parameterValue = selectedParameter.AsString();
                        if (!string.IsNullOrEmpty(parameterValue))
                        {
                            distinctValues.Add(parameterValue);
                        }
                    }
                }

                // Utiliza Dispatcher para modificar a UI
                Dispatcher.Invoke(() =>
                {
                    // Atualiza FilterValues com os valores distintos
                    FilterValues.Clear();
                    foreach (var value in distinctValues)
                    {
                        FilterValues.Add(value);
                    }

                    // Atualiza o ComboBox com a nova lista
                    Cb_InsertViewsOnSheetFilterForViewsValue.ItemsSource = FilterValues.ToList();
                });
            }
        }
        #endregion

        private void Btn_ViewNameRename_Click(object sender, RoutedEventArgs e)
        {

        }
        private void UpdateUIForCultureChange()
        {
            // Atualizar componentes visuais, se necessário
        }

        #region método que insere no label Lb_InsertViewOnSheetsSelectedViewsCount a quantidade de vistas que serão inseridas nas folhas - Cb_InsertViewsOnSheetFilterForViewsValue_SelectionChanged
        private void Cb_InsertViewsOnSheetFilterForViewsValue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtém o valor selecionado no combobox
            string selectedFilterValue = Cb_InsertViewsOnSheetFilterForViewsValue.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedFilterValue))
            {
                // Filtra as vistas com base no valor selecionado
                IEnumerable<Autodesk.Revit.DB.View> filteredViews = FilterViewsByParameter(selectedFilterValue);

                // Obtém a contagem de vistas filtradas
                int filteredViewsCount = filteredViews.Count();

                // Atualiza o label com o número de vistas filtradas
                Lb_InsertViewOnSheetsSelectedViewsCount.Content = $"{filteredViewsCount}";

                // Exibe os nomes das vistas filtradas em ordem alfabética em um TaskDialog
                TaskDialog taskDialog = new TaskDialog("Nomes das Vistas Filtradas");

                // Adiciona os nomes das vistas ao conteúdo do TaskDialog
                taskDialog.MainContent = string.Join("\n", filteredViews.Select(view => view.Name).OrderBy(name => name));

                // Exibe o TaskDialog
                TaskDialogResult result = taskDialog.Show();
            }
        }


        // Método para filtrar as vistas com base no valor do parâmetro selecionado
        private IEnumerable<Autodesk.Revit.DB.View> FilterViewsByParameter(string selectedFilterValue)
        {
            return new FilteredElementCollector(doc)
                .OfClass(typeof(Autodesk.Revit.DB.View))
                .Cast<Autodesk.Revit.DB.View>()
                .Where(view =>
                {
                    Autodesk.Revit.DB.Parameter selectedParameter = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>()
                        .FirstOrDefault(p => p.Definition.Name == Cb_InsertViewOnSheetsViewParametersForView.SelectedItem?.ToString());

                    return selectedParameter != null && selectedParameter.AsString() == selectedFilterValue;
                });
        }

        #endregion

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
