using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevitEasy.RenameViews.Forms
{
    public partial class Wf_RenameViews : System.Windows.Forms.Form
    {
        private readonly Document doc;

        // Construtor do formulário
        public Wf_RenameViews(Document document)
        {
            InitializeComponent();
            doc = document; // Inicializa o documento
        }



        #region Ação que é executada ao abrir o formulário
        private void Ld_RenameViews(object sender, EventArgs e)
        {
            // Adicione o evento ao combobox Cb_RenameViewsInstanceParameters aqui
            Cb_RenameViewsInstanceParameters.SelectedIndexChanged += Cb_RenameViewsInstanceParameters_SelectedIndexChanged;

            // Carrega os ViewTypes no combobox
            LoadViewTypes();
        }

        #endregion

        #region Métodos para receber os inputs do formulário e criar as folhas
        // Método chamado quando o botão de criação é clicado
        private void Btn_ViewNameRename_Click(object sender, EventArgs e)
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

        #region Método para obter as vistas disponíveis no modelo filtrando pela viewType que foi selecionada no combobox Cb_RenameViewsType e logo em seguida, obtendo os parametros de instancia do modelo e colocando-os no combobox
        private void LoadInstanceParametersInSelectView()
        {
            // Obtém o ViewType que foi selecionado no combobox Cb_RenameViewsType
            string selectedViewsType = Cb_RenameViewsType.SelectedItem?.ToString();

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
                Cb_RenameViewsInstanceParameters.DataSource = instanceParametersList;
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
        // Esse é um evento que é executado sempre que o Tipo de vista é selecionado no combobox Cb_RenameViewsType
        private void Sic_RenameViewsType(object sender, EventArgs e)
        {
            //Aqui se carrega o método que obtém as vistas disponíveis no modelo correspondente ao viewType Que foi selecioado no combobox Cb_RenameViewsType
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
                IList<string> viewTypesName = viewTypes.Select(t => t.Name).ToList();

                // Atualiza o ComboBox apenas se não estiver vazio
                if (viewTypesName.Count > 0)
                {
                    Cb_RenameViewsType.DataSource = viewTypesName;
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
        public string RenameViewsFilteValue => Cb_RenameViewsFilterValue.Text;
        public string RenameViewNamePreffix => Tb_RenameViewNamePreffix.Text;
        public string RenameViewNameSuffix => Tb_RenameViewNameSuffix.Text;
        #endregion

        #region Métodos vazios que não exigem nenhuma ação mas que devem ser mantidos para que o código funcione corretamente
        private void Tb_RenameViewNameNumberStarts_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kp_RenameViewNamePreffix(object sender, KeyPressEventArgs e)
        {

        }

        private void Kp_RenameViewNameNumberStarts(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um número ou a tecla "Backspace"
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // Aceita a tecla pressionada
            }
            else
            {
                e.Handled = true; // Ignora a tecla pressionada
                MessageBox.Show("Digite apenas números inteiros");
            }
        }
        #endregion

        #region Método para obter vistas, obter parametros, agrupar-los em lista, e colocar no combobox Cb_RenameViewsInstanceParameters
        private void Cb_RenameViewsInstanceParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há um parâmetro selecionado no combobox
            string selectedParameterName = Cb_RenameViewsInstanceParameters.SelectedItem?.ToString();

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
                Cb_RenameViewsFilterValue.Items.Clear();

                // Adiciona os valores distintos diretamente ao combobox, se a lista não for vazia
                if (filterValues.Any())
                {
                    // Adiciona os valores apenas se houver itens
                    foreach (var value in filterValues)
                    {
                        Cb_RenameViewsFilterValue.Items.Add(value);
                    }
                }
                else
                {

                }

                // Mensagem de depuração
                Console.WriteLine("Cb_RenameViewsFilteValue.DataSource atualizado com sucesso.");
                Console.WriteLine("Valores distintos no filtro: " + string.Join(", ", filterValues));
            }
        }






        #endregion

        private void Cb_RenameViewsFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tb_RenameViewNamePreffix_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Tb_RenameViewNameSuffix_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

