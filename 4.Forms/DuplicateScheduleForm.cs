using Autodesk.Internal.Windows;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.ExtensibleStorage;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace RevitEasy.DuplicateSheduleForm.Forms
{
    public partial class DuplicateScheduleForm : System.Windows.Forms.Form
    {
        private readonly Document doc;

        // Construtor do formulário
        public DuplicateScheduleForm(Document document)
        {
            InitializeComponent();
            doc = document; // Inicializa o documento
        }

        // Método chamado ao carregar o formulário
        private void DuplicateScheduleForm_Load(object sender, EventArgs e)
        {
            // Carrega as ViewSchedules no ComboBox
            LoadSchedules();
        }





        #region Métodos para obter as tabelas disponíveis no modelo aqui é onde o principal acontece, muito cuidado 
        // Método para carregar as tabelas no ComboBox
        private void LoadSchedules()
        {
            try
            {
                // Obtém todas as ViewSchedule no modelo
                IList<ViewSchedule> scheduleViews = new FilteredElementCollector(doc)
                    .OfCategory(BuiltInCategory.OST_Schedules)
                    .OfClass(typeof(ViewSchedule))
                    .Cast<ViewSchedule>()
                    .ToList();

                // Obtém os nomes das tabelas
                IList<string> scheduleNames = scheduleViews.Select(schedule => schedule.Name).ToList();

                // Atualiza o ComboBox apenas se não estiver vazio
                if (scheduleNames.Count > 0)
                {
                    Cb_DuplicateSchedule.DataSource = scheduleNames;
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Erro ao carregar as tabelas do modelo", ex.ToString());
            }
        }


        #region Métodos para receber os inputs do formulário e duplicar as tabelas
        // Método chamado quando o botão de duplicação é clicado
        private void Btn_DuplicateScheduleDuplicate_Click(object sender, EventArgs e)
        {
            // Obtém a ViewSchedule selecionada no ComboBox
            string selectedScheduleName = this.Cb_DuplicateSchedule.SelectedItem?.ToString();
            ViewSchedule selectedSchedule = GetViewScheduleByName(selectedScheduleName);

            // Verifica se os campos obrigatórios foram preenchidos
            if (selectedSchedule == null)
            {
                TaskDialog.Show("Campos vazios", "Selecione uma tabela para duplicar.");
            }
            else
            {
                // Obtém o intervalo de tabelas
                int starts = int.Parse(DuplicateScheduleNumberStarts);
                int ends = int.Parse(DuplicateScheduleNumberEnds);

                // Cria uma transação para a duplicação da tabela
                using (TransactionGroup group = new TransactionGroup(doc, "Duplicate Schedules"))
                {
                    group.Start();

                    try
                    {
                        // Itera sobre o intervalo de duplicação (ajuste conforme necessário)
                        for (int DuplicateScheduleNumber = starts; DuplicateScheduleNumber <= ends; DuplicateScheduleNumber++)
                        {
                            string FormattedScheduleNumberForName = DuplicateScheduleNumber < 10 ? "0" + DuplicateScheduleNumber :
                                                                    DuplicateScheduleNumber < 100 ? "" + DuplicateScheduleNumber :
                                                                    DuplicateScheduleNumber.ToString();

                            // Duplica a tabela no Revit
                            using (Transaction duplicationTransaction = new Transaction(doc, "Duplicate Schedule"))
                            {
                                duplicationTransaction.Start();

                                ViewSchedule duplicatedSchedule = doc.GetElement(selectedSchedule.Duplicate(ViewDuplicateOption.Duplicate)) as ViewSchedule;

                                // Nome da tabela duplicada (ajuste conforme necessário)
                                duplicatedSchedule.Name = DuplicateScheduleName + (FormattedScheduleNumberForName) + DuplicateScheduleNameSuffix;

                                // Adiciona o filtro à tabela duplicada
                                AddFilterToDuplicatedSchedule(duplicatedSchedule,
                                                              this.Cb_DuplicateScheduleFilterValue.SelectedItem?.ToString(),
                                                              (ScheduleFilterType)Enum.Parse(typeof(ScheduleFilterType), this.Cb_ScheduleFilterType.SelectedItem?.ToString()),
                                                              FormattedScheduleNumberForName);

                                duplicationTransaction.Commit();
                            }
                        }

                        // Commit na transação do grupo
                        group.Assimilate();
                    }
                    catch (Exception ex)
                    {
                        // Se houver algum erro, role a transação do grupo de volta
                        group.RollBack();
                        TaskDialog.Show("Erro", ex.Message);
                    }
                }
            }
        }


        #endregion

        #region Obtém os nome da tabela selecinada
        private ViewSchedule GetViewScheduleByName(string name)
        {
            return new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_Schedules)
                .OfClass(typeof(ViewSchedule))
                .Cast<ViewSchedule>()
                .FirstOrDefault(t => t.Name == name);
        }

        #endregion


        #endregion

        #region  Método para adicionar filtro à tabela
        // Método para adicionar filtro à tabela
        private void AddFilterToDuplicatedSchedule(ViewSchedule duplicatedSchedule, string selectedFilterName, ScheduleFilterType selectedFilterType, string FormattedScheduleNumberForName)
        {
            try
            {
                // Obtém os valores dos TextBoxs
                string preffix = this.Tb_DuplicateSchedulePreffixFilter.Text;
                string suffix = this.Tb_DuplicateScheduleSuffixFilter.Text;

                // Combina os valores para criar o valor do filtro
                string filterValue = preffix + FormattedScheduleNumberForName + suffix;

                // Verifica se o filtro selecionado e os valores são válidos
                if (!string.IsNullOrEmpty(selectedFilterName) && !string.IsNullOrEmpty(filterValue))
                {
                    // Adiciona o filtro à tabela
                    ScheduleField scheduleField = FindField(duplicatedSchedule, selectedFilterName);

                    if (scheduleField != null)
                    {
                        // Limpa todos os filtros que estão na tabela 


                        // Cria um filtro
                        ScheduleFilter filter = new ScheduleFilter(scheduleField.FieldId, selectedFilterType, filterValue);

                        // Adiciona o filtro à tabela
                        duplicatedSchedule.Definition.AddFilter(filter);
                    }
                    else
                    {
                        TaskDialog.Show("Campo não encontrado", "O campo da tabela não foi encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Erro ao adicionar filtro à tabela", ex.ToString());
            }
        }

        #region Método que limpa os filtros adicionados a tabela e adiciona novos

        #endregion


        #endregion

        #region Métodos para converter os valores dos inputs do usuário em texto
        // Métodos para converter os valores dos inputs do usuário em texto
        public string DuplicateScheduleNumberStarts => this.Tb_DuplicateScheduleNumberStarts.Text;
        public string DuplicateScheduleNumberEnds => this.Tb_DuplicateScheduleNumberEnds.Text;
        public string DuplicateScheduleName => this.Tb_DuplicateScheduleName.Text;
        public string DuplicateScheduleFilterValue => this.Cb_DuplicateScheduleFilterValue.Text;
        public string DuplicateSchedulePreffixFilter => this.Tb_DuplicateSchedulePreffixFilter.Text;
        public string DuplicateScheduleNameSuffix => this.Tb_DuplicateScheduleNameSuffix.Text;


        #endregion

        #region Método chamado quando o botão de cancelar é clicado
        // Método chamado quando o botão de cancelar é clicado
        private void Btn_DuplicateScheduleCancel_Click(object sender, EventArgs e)
        {
            // Define o resultado do formulário como Cancel e o fecha
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Métodos vazios para eventos que não exigem ação
        private void Label1_Click(object sender, EventArgs e) { }
        private void Label3_Click(object sender, EventArgs e) { }
        private void Label2_Click(object sender, EventArgs e) { }
        private void TextBox1_TextChanged(object sender, EventArgs e) { }
        private void Tb_DuplicateScheduleFilterValue_TextChanged(object sender, EventArgs e) { }
        private void Label4_Click(object sender, EventArgs e) { }
        #endregion



        #region Açao executada ao selecionar uma tabela disponível do modelo
        //aqui ficará disponível os campos que poderão ser adicionados a schedule e carregar lista no combobox


        private void Sic_DuplicateSchedule(object sender, EventArgs e)
        {
            // Obtém a ViewSchedule selecionada no ComboBox
            string selectedScheduleName = this.Cb_DuplicateSchedule.SelectedItem?.ToString();
            ViewSchedule selectedSchedule = GetViewScheduleByName(selectedScheduleName);

            // Chama o método para carregar os campos da tabela no ComboBox
            LoadFields(selectedSchedule);

        }

        // Método para carregar os campos de filtro da tabela no ComboBox
        private void LoadFields(ViewSchedule selectedSchedule)
        {
            try
            {
                // Limpa os itens existentes no ComboBox
                Cb_DuplicateScheduleFilterValue.Items.Clear();

                // Verifica se há uma tabela selecionada
                if (selectedSchedule != null)
                {
                    // Obtém a definição da tabela selecionada
                    ScheduleDefinition definition = selectedSchedule.Definition;

                    // Itera sobre os campos da definição da tabela
                    foreach (ScheduleFieldId fieldId in definition.GetFieldOrder())
                    {
                        ScheduleField field = definition.GetField(fieldId);

                        // Adiciona os campos ao ComboBox
                        Cb_DuplicateScheduleFilterValue.Items.Add(field.GetName());
                    }

                    // Se desejar, pode selecionar automaticamente o primeiro item no ComboBox
                    if (Cb_DuplicateScheduleFilterValue.Items.Count > 0)
                    {
                        Cb_DuplicateScheduleFilterValue.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Erro ao carregar os campos da tabela", ex.ToString());
            }
        }

        #region Métodos para obter os fields disponíveis na tabela

        // Método para encontrar um campo na definição da tabela
        private ScheduleField FindField(ViewSchedule schedule, string fieldName)
        {
            ScheduleDefinition definition = schedule.Definition;

            // Itera sobre os campos da definição da tabela
            foreach (ScheduleFieldId fieldId in definition.GetFieldOrder())
            {
                ScheduleField field = definition.GetField(fieldId);

                // Verifica se o nome do campo corresponde ao campo desejado
                if (field.GetName() == fieldName)
                {
                    return field;
                }
            }

            return null; // Retorna nulo se o campo não for encontrado
        }


        #endregion de acão executada ao selecionar um modelo de tabela 

        #region Obter tipos de filtro para tabela 

        // Vincule o evento SelectedIndexChanged ao Cb_DuplicateScheduleFilterValue
        private void Cb_DuplicateScheduleFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chame o método Sic_FieldSelect quando o índice do item selecionado mudar
            Sic_FieldSelect(sender, e);
        }

        private void Sic_FieldSelect(object sender, EventArgs e)
        {
            // Obtém o nome do campo selecionado
            string selectedFieldName = this.Cb_DuplicateScheduleFilterValue.SelectedItem?.ToString();

            // Chama o método para carregar os tipos de filtro no Cb_ScheduleFilterType
            LoadFilterTypes(selectedFieldName);
        }

        #region Método para carregar os tipos de filtro no ComboBox de tipos de filtro

        //Método para carregar os tipos de filtro no ComboBox de tipos de filtro
        private void LoadFilterTypes(string selectedFieldName)
        {
            // Limpa os itens existentes no ComboBox de tipos de filtro
            Cb_ScheduleFilterType.Items.Clear();

            // Verifica se há um campo selecionado
            if (!string.IsNullOrEmpty(selectedFieldName))
            {
                // Obtém a ViewSchedule selecionada no ComboBox
                string selectedScheduleName = this.Cb_DuplicateSchedule.SelectedItem?.ToString();
                ViewSchedule selectedSchedule = GetViewScheduleByName(selectedScheduleName);

                // Obtém a definição da tabela selecionada
                ScheduleDefinition definition = selectedSchedule.Definition;

                // Encontra o campo da tabela
                ScheduleField scheduleField = FindField(selectedSchedule, selectedFieldName);

                // Verifica se o campo foi encontrado
                if (scheduleField != null)
                {
                    // Obtém os tipos de filtro disponíveis para o campo
                    IList<ScheduleFilterType> filterTypes = GetFilterTypesForField(scheduleField);

                    // Adiciona os tipos de filtro ao ComboBox de tipos de filtro
                    foreach (ScheduleFilterType filterType in filterTypes)
                    {
                        Cb_ScheduleFilterType.Items.Add(filterType.ToString());
                    }

                    // Se desejar, pode selecionar automaticamente o primeiro item no ComboBox de tipos de filtro
                    if (Cb_ScheduleFilterType.Items.Count > 0)
                    {
                        Cb_ScheduleFilterType.SelectedIndex = 0;
                    }
                }
                else
                {
                    TaskDialog.Show("Campo não encontrado", "O campo da tabela não foi encontrado.");
                }
            }
        }

        private IList<ScheduleFilterType> GetFilterTypesForField(ScheduleField scheduleField)
        {
            if (scheduleField is null)
            {
                throw new ArgumentNullException(nameof(scheduleField));
            }

            return new List<ScheduleFilterType>
             {
                ScheduleFilterType.Equal,
                ScheduleFilterType.NotEqual,
                ScheduleFilterType.NotEndsWith,
                ScheduleFilterType.LessThan,
                ScheduleFilterType.GreaterThan,
                ScheduleFilterType.LessThanOrEqual,
                ScheduleFilterType.GreaterThanOrEqual,
                ScheduleFilterType.BeginsWith,
                ScheduleFilterType.HasNoValue,
                ScheduleFilterType.Contains,
                ScheduleFilterType.EndsWith,
                ScheduleFilterType.HasValue,


            };
        }



        #endregion

        #endregion

        #endregion

        private void Tb_DuplicateScheduleNumberStarts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}