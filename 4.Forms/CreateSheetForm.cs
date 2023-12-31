﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevitEasy.DuplicateSheduleForm.Forms
{
    public partial class CreateSheetForm : System.Windows.Forms.Form
    {
        private readonly Document doc;

        // Construtor do formulário
        public CreateSheetForm(Document document)
        {
            InitializeComponent();
            doc = document; // Inicializa o documento
        }

        // Método chamado ao carregar o formulário
        private void CreateSheetForm_Load(object sender, EventArgs e)
        {
            // Carrega os FamilyTypes no ComboBox
            LoadTitleBlocks();
        }

        #region Métodos para receber os inputs do formulário e criar as folhas
        // Método chamado quando o botão de criação é clicado
        private void Btn_create_Click(object sender, EventArgs e)
        {
            // Obtém o Title Block selecionado no ComboBox
            string selectedTBlock = this.sheet_titleBlock.SelectedItem?.ToString();
            FamilySymbol titleBlock = GetFamilySymbolByName(selectedTBlock);

            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrEmpty(SheetName) || string.IsNullOrEmpty(SheetNumberStarts) || string.IsNullOrEmpty(SheetNumberEnds) || titleBlock == null)
            {
                TaskDialog.Show("Campos vazios", "Um ou mais campos estão vazios ou não foram preenchidos corretamente");
            }
            else
            {
                // Obtém o intervalo de folhas
                int starts = int.Parse(SheetNumberStarts);
                int ends = int.Parse(SheetNumberEnds);

                // Cria uma transação para a criação das folhas
                using (Transaction sheetTrans = new Transaction(doc, "Create Sheets"))
                {
                    sheetTrans.Start();

                    // Itera sobre o intervalo de folhas e cria uma folha para cada número
                    for (int SheetNumber = starts; SheetNumber <= ends; SheetNumber++)
                    {
                        // Formata o número para sheet number
                        string formattedSheetNumber = SheetNumber < 10 ? "00" + SheetNumber :
                                                      SheetNumber < 100 ? "0" + SheetNumber :
                                                      SheetNumber.ToString();

                        // Formata o número que vai para o sheet name
                        string formattedSheetNumberForName = SheetNumber < 10 ? "0" + SheetNumber :
                                                             SheetNumber < 100 ? "" + SheetNumber :
                                                             SheetNumber.ToString();

                        // Cria a folha no Revit
                        ViewSheet viewSheet = ViewSheet.Create(doc, titleBlock.Id);
                        viewSheet.Name = SheetNamePreffix + SheetName + formattedSheetNumberForName + SheetNameSuffix;
                        viewSheet.SheetNumber = SheetNumberPreffix + formattedSheetNumber + SheetNumberSuffix;
                    }

                    // Finaliza a transação
                    sheetTrans.Commit();
                }
            }
        }
        #endregion

        #region Métodos para obter os familytypes de Title Blocks
        // Método para carregar os FamilyTypes no ComboBox
        private void LoadTitleBlocks()
        {
            try
            {
                // Obtém todos os símbolos (types) de Title Blocks no modelo
                IList<FamilySymbol> tBlocksTypes = new FilteredElementCollector(doc)
                    .OfCategory(BuiltInCategory.OST_TitleBlocks)
                    .OfClass(typeof(FamilySymbol))
                    .Cast<FamilySymbol>()
                    .ToList();

                // Obtém os nomes dos Title Blocks
                IList<string> tBlocksNames = tBlocksTypes.Select(t => t.Name).ToList();

                // Atualiza o ComboBox apenas se não estiver vazio
                if (tBlocksNames.Count > 0)
                {
                    sheet_titleBlock.DataSource = tBlocksNames;
                }
            }
            catch (Exception ex)
            {
                TaskDialog.Show("O modelo não possui nenhuma família de folha, carregue a família desejada no modelo", ex.ToString());
            }
        }

        // Método para obter FamilySymbol pelo nome
        private FamilySymbol GetFamilySymbolByName(string name)
        {
            return new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_TitleBlocks)
                .OfClass(typeof(FamilySymbol))
                .Cast<FamilySymbol>()
                .FirstOrDefault(t => t.Name == name);
        }
        #endregion

        #region Métodos para converter os valores dos inputs do usuário em texto
        // Métodos para converter os valores dos inputs do usuário em texto
        public string SheetNamePreffix => this.Sheet_name_preffix.Text;
        public string SheetName => this.Sheet_name.Text;
        public string SheetNameSuffix => this.Sheet_name_suffix.Text;
        public string SheetNumberPreffix => this.Sheet_number_preffix.Text;
        public string SheetNumberStarts => this.Sheet_number_starts.Text;
        public string SheetNumberEnds => this.Sheet_number_ends.Text;
        public string SheetNumberSuffix => this.Sheet_number_suffix.Text;

        // Método chamado quando o botão de cancelar é clicado
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            // Define o resultado do formulário como Cancel e o fecha
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Métodos vazios para eventos que não exigem ação
        // Métodos vazios para eventos que não exigem ação
        private void Label1_Click(object sender, EventArgs e) { }
        private void Label_Click(object sender, EventArgs e) { }
        private void Sheet_name_TextChanged(object sender, EventArgs e) { }
        private void Sheet_number_TextChanged(object sender, EventArgs e) { }

        // Método chamado quando o item selecionado no ComboBox de Title Blocks é alterado
        private void Sheet_titleBlock_SelectedIndexChanged(object sender, EventArgs e){ }
        private void Label3_Click(object sender, EventArgs e) { }
        private void Label7_Click(object sender, EventArgs e) { }
        private void Sheet_number_suffix_TextChanged(object sender, EventArgs e){ }
        private void Sheet_name_preffix_TextChanged(object sender, EventArgs e) { }
        private void Sheet_name_TextChanged_1(object sender, EventArgs e) { }
        private void Sheet_name_preffix_TextChanged_1(object sender, EventArgs e) { }
        private void Sheet_number_preffix_TextChanged(object sender, EventArgs e) { }
        private void Guna2Button1_Click(object sender, EventArgs e) { }
        private void Sheet_number_starts_TextChanged(object sender, EventArgs e) { }
        #endregion

        #region Métodos para nudar a aparencia e verificar se os inputs dos usuários são válidos
        private void Sheet_number_preffix_Enter(object sender, EventArgs e)
        {
            Sheet_number_preffix.BackColor = System.Drawing.Color.LightYellow;
        }

        private void Sheet_number_preffix_Leave(object sender, EventArgs e)
        {
            Sheet_number_preffix.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
        }

        private void Sheet_number_starts_Enter(object sender, EventArgs e)
        {
            Sheet_number_starts.BackColor = System.Drawing.Color.LightYellow;
        }

        private void Sheet_number_starts_Leave(object sender, EventArgs e)
        {
            Sheet_number_starts.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
        }

        private void Sheet_number_ends_Enter(object sender, EventArgs e)
        {
            Sheet_number_ends.BackColor = System.Drawing.Color.LightYellow;
        }

        private void Sheet_number_ends_Leave(object sender, EventArgs e)
        {
            Sheet_number_ends.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
        }

        private void Sheet_number_starts_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Sheet_name_suffix_Enter(object sender, EventArgs e)
        {
            Sheet_number_ends.BackColor = System.Drawing.Color.LightYellow;
        }

        private void Sheet_name_suffix_Leave(object sender, EventArgs e)
        {
            Sheet_number_ends.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
        }

        private void Sheet_number_ends_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sheet_number_ends_KeyPress(object sender, KeyPressEventArgs e)
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
            #endregion


        }

        private void Sheet_titleBlock_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Btn_CancelClick(object sender, EventArgs e)
        {
            // Define o resultado do formulário como Cancel e o fecha
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
