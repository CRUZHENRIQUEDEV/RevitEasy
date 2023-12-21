// Este é o código para o formulário CreateSheetsForms
namespace AppIExternalApplication.CreateSheet
{
    partial class CreateSheetsForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstSheetNumberTitle = new System.Windows.Forms.Label();
            this.RunButtonSheetCreate = new System.Windows.Forms.Button();
            this.FirstSheetNumberInput = new System.Windows.Forms.TextBox();
            this.LastSheetNumber = new System.Windows.Forms.TextBox();
            this.LastSheetNumberInput = new System.Windows.Forms.Label();
            this.TitleBlockTypeIdInput = new System.Windows.Forms.TextBox();
            this.SheetFamilyTitle = new System.Windows.Forms.Label();
            this.PrefixSheetNumberInput = new System.Windows.Forms.TextBox();
            this.PrefixSheetNumberTitle = new System.Windows.Forms.Label();
            this.SuffixSheetNumberInput = new System.Windows.Forms.TextBox();
            this.SuffixSheetNumberTitle = new System.Windows.Forms.Label();
            this.SheetNumberTitle = new System.Windows.Forms.Label();
            this.SheetNameTitle = new System.Windows.Forms.Label();
            this.SheetNameInput = new System.Windows.Forms.TextBox();
            this.SheetNameTitleinput = new System.Windows.Forms.Label();
            this.PreffixSheetNameInput = new System.Windows.Forms.TextBox();
            this.PrefixSheetNameTitle = new System.Windows.Forms.Label();
            this.SuffixSheetNameInput = new System.Windows.Forms.TextBox();
            this.SuffixSheetName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstSheetNumberTitle
            // 
            this.FirstSheetNumberTitle.AutoSize = true;
            this.FirstSheetNumberTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSheetNumberTitle.Location = new System.Drawing.Point(1, 152);
            this.FirstSheetNumberTitle.Name = "FirstSheetNumberTitle";
            this.FirstSheetNumberTitle.Size = new System.Drawing.Size(201, 19);
            this.FirstSheetNumberTitle.TabIndex = 0;
            this.FirstSheetNumberTitle.Text = "Número da primeira folha";
            // 
            // RunButtonSheetCreate
            // 
            this.RunButtonSheetCreate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButtonSheetCreate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RunButtonSheetCreate.Location = new System.Drawing.Point(7, 501);
            this.RunButtonSheetCreate.Name = "RunButtonSheetCreate";
            this.RunButtonSheetCreate.Size = new System.Drawing.Size(130, 31);
            this.RunButtonSheetCreate.TabIndex = 1;
            this.RunButtonSheetCreate.Text = "Criar";
            this.RunButtonSheetCreate.UseVisualStyleBackColor = true;
            // 
            // FirstSheetNumberInput
            // 
            this.FirstSheetNumberInput.Location = new System.Drawing.Point(6, 174);
            this.FirstSheetNumberInput.Name = "FirstSheetNumberInput";
            this.FirstSheetNumberInput.Size = new System.Drawing.Size(202, 20);
            this.FirstSheetNumberInput.TabIndex = 2;
            // 
            // LastSheetNumber
            // 
            this.LastSheetNumber.Location = new System.Drawing.Point(6, 224);
            this.LastSheetNumber.Name = "LastSheetNumber";
            this.LastSheetNumber.Size = new System.Drawing.Size(202, 20);
            this.LastSheetNumber.TabIndex = 4;
            // 
            // LastSheetNumberInput
            // 
            this.LastSheetNumberInput.AutoSize = true;
            this.LastSheetNumberInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastSheetNumberInput.Location = new System.Drawing.Point(2, 202);
            this.LastSheetNumberInput.Name = "LastSheetNumberInput";
            this.LastSheetNumberInput.Size = new System.Drawing.Size(185, 19);
            this.LastSheetNumberInput.TabIndex = 3;
            this.LastSheetNumberInput.Text = "Número da última folha";
            this.LastSheetNumberInput.UseMnemonic = false;
            // 
            // TitleBlockTypeIdInput
            // 
            this.TitleBlockTypeIdInput.Location = new System.Drawing.Point(11, 31);
            this.TitleBlockTypeIdInput.Name = "TitleBlockTypeIdInput";
            this.TitleBlockTypeIdInput.Size = new System.Drawing.Size(202, 20);
            this.TitleBlockTypeIdInput.TabIndex = 6;
            this.TitleBlockTypeIdInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SheetFamilyTitle
            // 
            this.SheetFamilyTitle.AutoSize = true;
            this.SheetFamilyTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetFamilyTitle.Location = new System.Drawing.Point(8, 9);
            this.SheetFamilyTitle.Name = "SheetFamilyTitle";
            this.SheetFamilyTitle.Size = new System.Drawing.Size(128, 19);
            this.SheetFamilyTitle.TabIndex = 5;
            this.SheetFamilyTitle.Text = "Família da folha";
            this.SheetFamilyTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // PrefixSheetNumberInput
            // 
            this.PrefixSheetNumberInput.Location = new System.Drawing.Point(6, 129);
            this.PrefixSheetNumberInput.Name = "PrefixSheetNumberInput";
            this.PrefixSheetNumberInput.Size = new System.Drawing.Size(202, 20);
            this.PrefixSheetNumberInput.TabIndex = 8;
            this.PrefixSheetNumberInput.Text = "01";
            // 
            // PrefixSheetNumberTitle
            // 
            this.PrefixSheetNumberTitle.AutoSize = true;
            this.PrefixSheetNumberTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefixSheetNumberTitle.Location = new System.Drawing.Point(3, 107);
            this.PrefixSheetNumberTitle.Name = "PrefixSheetNumberTitle";
            this.PrefixSheetNumberTitle.Size = new System.Drawing.Size(168, 19);
            this.PrefixSheetNumberTitle.TabIndex = 7;
            this.PrefixSheetNumberTitle.Text = "Prefixo número folha";
            this.PrefixSheetNumberTitle.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // SuffixSheetNumberInput
            // 
            this.SuffixSheetNumberInput.Location = new System.Drawing.Point(6, 269);
            this.SuffixSheetNumberInput.Name = "SuffixSheetNumberInput";
            this.SuffixSheetNumberInput.Size = new System.Drawing.Size(202, 20);
            this.SuffixSheetNumberInput.TabIndex = 10;
            // 
            // SuffixSheetNumberTitle
            // 
            this.SuffixSheetNumberTitle.AutoSize = true;
            this.SuffixSheetNumberTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuffixSheetNumberTitle.Location = new System.Drawing.Point(2, 247);
            this.SuffixSheetNumberTitle.Name = "SuffixSheetNumberTitle";
            this.SuffixSheetNumberTitle.Size = new System.Drawing.Size(163, 19);
            this.SuffixSheetNumberTitle.TabIndex = 9;
            this.SuffixSheetNumberTitle.Text = "Sufixo número folha";
            // 
            // SheetNumberTitle
            // 
            this.SheetNumberTitle.AutoSize = true;
            this.SheetNumberTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetNumberTitle.Location = new System.Drawing.Point(7, 67);
            this.SheetNumberTitle.Name = "SheetNumberTitle";
            this.SheetNumberTitle.Size = new System.Drawing.Size(162, 22);
            this.SheetNumberTitle.TabIndex = 11;
            this.SheetNumberTitle.Text = "Número da folha";
            this.SheetNumberTitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // SheetNameTitle
            // 
            this.SheetNameTitle.AutoSize = true;
            this.SheetNameTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetNameTitle.Location = new System.Drawing.Point(7, 306);
            this.SheetNameTitle.Name = "SheetNameTitle";
            this.SheetNameTitle.Size = new System.Drawing.Size(142, 22);
            this.SheetNameTitle.TabIndex = 12;
            this.SheetNameTitle.Text = "Nome da folha";
            this.SheetNameTitle.Click += new System.EventHandler(this.label6_Click);
            // 
            // SheetNameInput
            // 
            this.SheetNameInput.Location = new System.Drawing.Point(6, 410);
            this.SheetNameInput.Name = "SheetNameInput";
            this.SheetNameInput.Size = new System.Drawing.Size(202, 20);
            this.SheetNameInput.TabIndex = 14;
            this.SheetNameInput.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // SheetNameTitleinput
            // 
            this.SheetNameTitleinput.AutoSize = true;
            this.SheetNameTitleinput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetNameTitleinput.Location = new System.Drawing.Point(3, 388);
            this.SheetNameTitleinput.Name = "SheetNameTitleinput";
            this.SheetNameTitleinput.Size = new System.Drawing.Size(137, 19);
            this.SheetNameTitleinput.TabIndex = 13;
            this.SheetNameTitleinput.Text = "Nome das folhas";
            this.SheetNameTitleinput.Click += new System.EventHandler(this.label7_Click);
            // 
            // PreffixSheetNameInput
            // 
            this.PreffixSheetNameInput.Location = new System.Drawing.Point(6, 364);
            this.PreffixSheetNameInput.Name = "PreffixSheetNameInput";
            this.PreffixSheetNameInput.Size = new System.Drawing.Size(202, 20);
            this.PreffixSheetNameInput.TabIndex = 16;
            this.PreffixSheetNameInput.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // PrefixSheetNameTitle
            // 
            this.PrefixSheetNameTitle.AutoSize = true;
            this.PrefixSheetNameTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefixSheetNameTitle.Location = new System.Drawing.Point(2, 342);
            this.PrefixSheetNameTitle.Name = "PrefixSheetNameTitle";
            this.PrefixSheetNameTitle.Size = new System.Drawing.Size(193, 19);
            this.PrefixSheetNameTitle.TabIndex = 15;
            this.PrefixSheetNameTitle.Text = "Prefixo nome das folhas";
            this.PrefixSheetNameTitle.Click += new System.EventHandler(this.label8_Click);
            // 
            // SuffixSheetNameInput
            // 
            this.SuffixSheetNameInput.Location = new System.Drawing.Point(6, 462);
            this.SuffixSheetNameInput.Name = "SuffixSheetNameInput";
            this.SuffixSheetNameInput.Size = new System.Drawing.Size(202, 20);
            this.SuffixSheetNameInput.TabIndex = 18;
            // 
            // SuffixSheetName
            // 
            this.SuffixSheetName.AutoSize = true;
            this.SuffixSheetName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuffixSheetName.Location = new System.Drawing.Point(0, 440);
            this.SuffixSheetName.Name = "SuffixSheetName";
            this.SuffixSheetName.Size = new System.Drawing.Size(188, 19);
            this.SuffixSheetName.TabIndex = 17;
            this.SuffixSheetName.Text = "Sufixo nome das folhas";
            this.SuffixSheetName.Click += new System.EventHandler(this.label9_Click);
            // 
            // CreateSheetsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(212, 541);
            this.Controls.Add(this.SuffixSheetNameInput);
            this.Controls.Add(this.SuffixSheetName);
            this.Controls.Add(this.PreffixSheetNameInput);
            this.Controls.Add(this.PrefixSheetNameTitle);
            this.Controls.Add(this.SheetNameInput);
            this.Controls.Add(this.SheetNameTitleinput);
            this.Controls.Add(this.SheetNameTitle);
            this.Controls.Add(this.SheetNumberTitle);
            this.Controls.Add(this.SuffixSheetNumberInput);
            this.Controls.Add(this.SuffixSheetNumberTitle);
            this.Controls.Add(this.PrefixSheetNumberInput);
            this.Controls.Add(this.PrefixSheetNumberTitle);
            this.Controls.Add(this.TitleBlockTypeIdInput);
            this.Controls.Add(this.SheetFamilyTitle);
            this.Controls.Add(this.LastSheetNumber);
            this.Controls.Add(this.LastSheetNumberInput);
            this.Controls.Add(this.FirstSheetNumberInput);
            this.Controls.Add(this.RunButtonSheetCreate);
            this.Controls.Add(this.FirstSheetNumberTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateSheetsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crias várias folhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstSheetNumberTitle;
        private System.Windows.Forms.Button RunButtonSheetCreate;
        private System.Windows.Forms.TextBox FirstSheetNumberInput;
        private System.Windows.Forms.TextBox LastSheetNumber;
        private System.Windows.Forms.Label LastSheetNumberInput;
        private System.Windows.Forms.TextBox TitleBlockTypeIdInput;
        private System.Windows.Forms.Label SheetFamilyTitle;
        private System.Windows.Forms.TextBox PrefixSheetNumberInput;
        private System.Windows.Forms.Label PrefixSheetNumberTitle;
        private System.Windows.Forms.TextBox SuffixSheetNumberInput;
        private System.Windows.Forms.Label SuffixSheetNumberTitle;
        private System.Windows.Forms.Label SheetNumberTitle;
        private System.Windows.Forms.Label SheetNameTitle;
        private System.Windows.Forms.TextBox SheetNameInput;
        private System.Windows.Forms.Label SheetNameTitleinput;
        private System.Windows.Forms.TextBox PreffixSheetNameInput;
        private System.Windows.Forms.Label PrefixSheetNameTitle;
        private System.Windows.Forms.TextBox SuffixSheetNameInput;
        private System.Windows.Forms.Label SuffixSheetName;
    }
}