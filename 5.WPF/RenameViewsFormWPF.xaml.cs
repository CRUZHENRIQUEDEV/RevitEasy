using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Autodesk.Revit.UI;
using RevitEasy.LoadViewTypes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using RevitEasy.WPF.Behaviors;

namespace RevitEasy._5.WPF
{
    public partial class RenameViewsFormWPF : Window
    {

        private readonly Document doc;
        private readonly ViewTypeManager viewTypeManager;
        private ObservableCollection<string> filterValues;

        public event PropertyChangedEventHandler PropertyChanged;

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

        // Construtor do formulário
        public RenameViewsFormWPF(Document document)
        {
            InitializeComponent();
            doc = document; // Inicializa o documento
            viewTypeManager = new ViewTypeManager(doc); // Adiciona a instância do ViewTypeManager                                            
            FilterValues = new ObservableCollection<string>(); // Inicializa a coleção
            RevitFormBehavior.Register(this); //back common to all forms
        }
        // Dicionário para armazenar os parâmetros de instância associados ao tipo de vista selecionado
        private Dictionary<string, List<string>> instanceParametersByViewType = new Dictionary<string, List<string>>();

        #region Ação que é executada ao abrir o formulário WPF_RenameViews_Loaded

        private void WPF_RenameViews_Loaded(object sender, RoutedEventArgs e)
        {
            // Adicione o evento ao combobox Cb_RenameViewsInstanceParameters aqui
            Cb_RenameViewsInstanceParameters.SelectionChanged += Cb_RenameViewsInstanceParameters_SelectionChanged;

            // Carrega os ViewTypes no combobox usando a instância viewTypeManager
            LoadViewTypes();

            // Carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType que foi selecionado no combobox Cb_RenameViewsType
            LoadInstanceParametersInSelectView();
        }

        #endregion

        #region Métodos para receber os inputs do formulário e criar as folhas Btn_RenameViews_Click
        // Método chamado quando o botão de criação é clicado
        private void Btn_RenameViews_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtém o nome do parâmetro de instância que será usado para filtrar as vistas selecionado no combobox
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

                    // Ordena as vistas com base nos números contidos em seus nomes, ou alfabeticamente se não houver números
                    filteredViews.Sort((v1, v2) =>
                    {
                        string name1 = v1.Name;
                        string name2 = v2.Name;

                        // Extrai os números dos nomes (se existirem)
                        string numStr1 = new string(name1.Where(char.IsDigit).ToArray());
                        string numStr2 = new string(name2.Where(char.IsDigit).ToArray());

                        if (!string.IsNullOrEmpty(numStr1) && !string.IsNullOrEmpty(numStr2))
                        {
                            // Ambos os nomes contêm números, compara os números
                            int num1 = int.Parse(numStr1);
                            int num2 = int.Parse(numStr2);
                            return num1.CompareTo(num2);
                        }
                        else
                        {
                            // Se um dos nomes não contiver números, compara alfabeticamente
                            return name1.CompareTo(name2);
                        }
                    });

                    // Renomear todas as vistas

                    // Obtém o número inicial para os novos nomes
                    int starts = int.Parse(Tb_RenameViewNameNumberStarts.Text);

                    // Itera sobre as vistas ordenadas para renomear
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
                    System.Windows.MessageBox.Show("Ocorreu um erro ao renomear a vista: Parâmetro ou valor vazios.");
                }
            }
            catch (Exception ex)
            {
                // Lidar com a situação em que ocorre uma exceção
                System.Windows.MessageBox.Show("Ocorreu um erro ao renomear a vista: " + ex.Message);
            }
        }

        #endregion

        #region Método para obter as vistas disponíveis no modelo filtrando pela viewType que foi selecionada no combobox Cb_RenameViewsType -LoadInstanceParametersInSelectView
        // Método para obter as vistas disponíveis no modelo e associar os parâmetros de instância ao tipo de vista
        [Obsolete]
        private void LoadInstanceParametersInSelectView()
        {
            // Obtém o ViewType que foi selecionado no combobox Cb_RenameViewsType
            string selectedViewsType = Cb_RenameViewsType.SelectedValue as string;

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
            Cb_RenameViewsInstanceParameters.ItemsSource = instanceParametersList.Distinct().ToList();

            // Atualiza o ComboBox Cb_RenameViewsFilterValue com os valores únicos dos parâmetros de instância
            Cb_RenameViewsFilterValue.ItemsSource = instanceParametersList.Distinct().ToList();
        }


        #endregion

        #region Método para renomear a vistas RenameViews
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

                    // Define o novo nome para a vista usando a lista de vistas na ordem que foi criada 
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

        #region Evento que é executado sempre que o Tipo de vista é selecionado no combobox Cb_RenameViewsType Cb_RenameViewsType_SelectionChanged
        // Evento que é executado sempre que o Tipo de vista é selecionado no combobox Cb_RenameViewsType
        [System.Obsolete]
        private void Cb_RenameViewsType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType que foi selecionado no combobox Cb_RenameViewsType
            LoadInstanceParametersInSelectView();
        }
        #endregion

        #region Método que verifica quais os ViewTypes estão disponíveis no modelo, LoadViewTypes
        // Método para carregar os ViewTypes no ComboBox Cb_RenameViewsType
        private void LoadViewTypes()
        {
            try
            {
                // Obtém todos os tipos de Views no modelo usando a instância viewTypeManager
                IList<string> viewTypesName = viewTypeManager.GetViewTypes();

                // Atualiza o ComboBox apenas se não estiver vazio
                if (viewTypesName.Count > 0)
                {
                    Cb_RenameViewsType.ItemsSource = viewTypesName;
                    Cb_RenameViewsType.SelectedIndex = 0; // Define o primeiro item como selecionado por padrão
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Erro", "Ocorreu um erro ao carregar os tipos de visualização: " + ex.Message);
            }
        }

        #endregion

        #region Evento que é executado sempre que o Parâmetro de instância é selecionado no combobox Cb_RenameViewsInstanceParameters -Cb_RenameViewsInstanceParameters_SelectionChanged
        // Evento que é executado sempre que o Parâmetro de instância é selecionado no combobox Cb_RenameViewsInstanceParameters
        private void Cb_RenameViewsInstanceParameters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedParameterName = Cb_RenameViewsInstanceParameters.SelectedItem?.ToString();

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
                    Cb_RenameViewsFilterValue.ItemsSource = FilterValues.ToList();
                });
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

        #region Métodos que nçao exigem nenhuma ação mas que são necessários
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

        private void Tb_RenameViewNamePreffix_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Tb_RenameViewNameNumberStarts_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é um número ou a tecla "Backspace"
            if (!IsNumericKey(e.Key) && e.Key != Key.Back)
            {
                e.Handled = true; // Ignora a tecla pressionada
                System.Windows.MessageBox.Show("Digite apenas números inteiros");
            }
        }
        private bool IsNumericKey(Key key)
        {
            // Verifica se o código da tecla está na faixa numérica, incluindo Tab e números do teclado numérico à direita
            return ((key >= Key.D0 && key <= Key.D9) || (key >= Key.NumPad0 && key <= Key.NumPad9)) || key == Key.Tab;
        }


        private void Tb_RenameViewNameNumberStarts_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Your TextChanged logic here
        }

        #endregion

        #region Acão executada quando o botão sair é clicado
        //Acão executada quando o botão sair é clicado
        [System.Obsolete]
        private void Btn_RenameViewsExit_Click(object sender, RoutedEventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }

        #endregion

    }
}