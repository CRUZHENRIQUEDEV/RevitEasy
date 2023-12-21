

namespace RevitEasy.InsertViewsOnSheetForm.forms
{
    partial class Form_InsertViewsOnSheets
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
            this.Cb_InsertViewOnSheetsViewTypeViews = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_InsertViewOnSheetsViewParametersForView = new System.Windows.Forms.ComboBox();
            this.Cb_InsertViewsOnSheetFilterForViewsValue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_InsertViewsOnSheetInsert = new System.Windows.Forms.Button();
            this.Lb_FirstTitleTipoDeVista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_InsertViewOnSheetsViewParametersForSheet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_InsertViewsOnSheetFilterForSheetsValue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_InsertViewOnSheetsSelectedViewsCount = new System.Windows.Forms.Label();
            this.Lb_InsertViewOnSheetsSelectedSheetsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cb_InsertViewOnSheetsViewTypeViews
            // 
            this.Cb_InsertViewOnSheetsViewTypeViews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_InsertViewOnSheetsViewTypeViews.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Cb_InsertViewOnSheetsViewTypeViews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_InsertViewOnSheetsViewTypeViews.FormattingEnabled = true;
            this.Cb_InsertViewOnSheetsViewTypeViews.Location = new System.Drawing.Point(15, 47);
            this.Cb_InsertViewOnSheetsViewTypeViews.Name = "Cb_InsertViewOnSheetsViewTypeViews";
            this.Cb_InsertViewOnSheetsViewTypeViews.Size = new System.Drawing.Size(220, 23);
            this.Cb_InsertViewOnSheetsViewTypeViews.TabIndex = 2;
            this.Cb_InsertViewOnSheetsViewTypeViews.Text = "Ex: Planta de piso";
            this.Cb_InsertViewOnSheetsViewTypeViews.SelectedIndexChanged += new System.EventHandler(this.Sic_InsertViewOnSheetsViewTypeViews);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label7.Location = new System.Drawing.Point(13, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome do parametro para filtrar";
            // 
            // Cb_InsertViewOnSheetsViewParametersForView
            // 
            this.Cb_InsertViewOnSheetsViewParametersForView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_InsertViewOnSheetsViewParametersForView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Cb_InsertViewOnSheetsViewParametersForView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_InsertViewOnSheetsViewParametersForView.FormattingEnabled = true;
            this.Cb_InsertViewOnSheetsViewParametersForView.Location = new System.Drawing.Point(15, 97);
            this.Cb_InsertViewOnSheetsViewParametersForView.Name = "Cb_InsertViewOnSheetsViewParametersForView";
            this.Cb_InsertViewOnSheetsViewParametersForView.Size = new System.Drawing.Size(220, 23);
            this.Cb_InsertViewOnSheetsViewParametersForView.TabIndex = 14;
            this.Cb_InsertViewOnSheetsViewParametersForView.Text = "Ex:Marca";
            this.Cb_InsertViewOnSheetsViewParametersForView.SelectedIndexChanged += new System.EventHandler(this.Sic_InsertViewOnSheetsViewParametersForView);
            // 
            // Cb_InsertViewsOnSheetFilterForViewsValue
            // 
            this.Cb_InsertViewsOnSheetFilterForViewsValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_InsertViewsOnSheetFilterForViewsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Cb_InsertViewsOnSheetFilterForViewsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_InsertViewsOnSheetFilterForViewsValue.FormattingEnabled = true;
            this.Cb_InsertViewsOnSheetFilterForViewsValue.Location = new System.Drawing.Point(15, 157);
            this.Cb_InsertViewsOnSheetFilterForViewsValue.Name = "Cb_InsertViewsOnSheetFilterForViewsValue";
            this.Cb_InsertViewsOnSheetFilterForViewsValue.Size = new System.Drawing.Size(220, 23);
            this.Cb_InsertViewsOnSheetFilterForViewsValue.TabIndex = 15;
            this.Cb_InsertViewsOnSheetFilterForViewsValue.SelectedIndexChanged += new System.EventHandler(this.Sic_InsertViewsOnSheetFilterForViewsValue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filtrar vistas pelo valor...";
            // 
            // Btn_InsertViewsOnSheetInsert
            // 
            this.Btn_InsertViewsOnSheetInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Btn_InsertViewsOnSheetInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InsertViewsOnSheetInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Btn_InsertViewsOnSheetInsert.Location = new System.Drawing.Point(83, 432);
            this.Btn_InsertViewsOnSheetInsert.Name = "Btn_InsertViewsOnSheetInsert";
            this.Btn_InsertViewsOnSheetInsert.Size = new System.Drawing.Size(152, 30);
            this.Btn_InsertViewsOnSheetInsert.TabIndex = 17;
            this.Btn_InsertViewsOnSheetInsert.Text = "INSERIR VISTAS";
            this.Btn_InsertViewsOnSheetInsert.UseVisualStyleBackColor = false;
            this.Btn_InsertViewsOnSheetInsert.Click += new System.EventHandler(this.Click_InsertViewOnSheetsEvent);
            // 
            // Lb_FirstTitleTipoDeVista
            // 
            this.Lb_FirstTitleTipoDeVista.AutoSize = true;
            this.Lb_FirstTitleTipoDeVista.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Lb_FirstTitleTipoDeVista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Lb_FirstTitleTipoDeVista.Location = new System.Drawing.Point(5, 9);
            this.Lb_FirstTitleTipoDeVista.Name = "Lb_FirstTitleTipoDeVista";
            this.Lb_FirstTitleTipoDeVista.Size = new System.Drawing.Size(103, 21);
            this.Lb_FirstTitleTipoDeVista.TabIndex = 18;
            this.Lb_FirstTitleTipoDeVista.Text = "Tipo de vista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(5, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Folhas";
            // 
            // Cb_InsertViewOnSheetsViewParametersForSheet
            // 
            this.Cb_InsertViewOnSheetsViewParametersForSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_InsertViewOnSheetsViewParametersForSheet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Cb_InsertViewOnSheetsViewParametersForSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_InsertViewOnSheetsViewParametersForSheet.FormattingEnabled = true;
            this.Cb_InsertViewOnSheetsViewParametersForSheet.Location = new System.Drawing.Point(15, 291);
            this.Cb_InsertViewOnSheetsViewParametersForSheet.Name = "Cb_InsertViewOnSheetsViewParametersForSheet";
            this.Cb_InsertViewOnSheetsViewParametersForSheet.Size = new System.Drawing.Size(220, 23);
            this.Cb_InsertViewOnSheetsViewParametersForSheet.TabIndex = 21;
            this.Cb_InsertViewOnSheetsViewParametersForSheet.Text = "Ex:Marca";
            this.Cb_InsertViewOnSheetsViewParametersForSheet.SelectedIndexChanged += new System.EventHandler(this.Cb_InsertViewOnSheetsViewParametersForSheet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome do parametro para filtrar";
            // 
            // Cb_InsertViewsOnSheetFilterForSheetsValue
            // 
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.FormattingEnabled = true;
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.Location = new System.Drawing.Point(15, 351);
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.Name = "Cb_InsertViewsOnSheetFilterForSheetsValue";
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.Size = new System.Drawing.Size(220, 23);
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.TabIndex = 22;
            this.Cb_InsertViewsOnSheetFilterForSheetsValue.SelectedIndexChanged += new System.EventHandler(this.Sic_InsertViewsOnSheetFilterForSheetsValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(14, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Filtrar folhas pelo valor...";
            // 
            // Lb_InsertViewOnSheetsSelectedViewsCount
            // 
            this.Lb_InsertViewOnSheetsSelectedViewsCount.AutoSize = true;
            this.Lb_InsertViewOnSheetsSelectedViewsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Lb_InsertViewOnSheetsSelectedViewsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Lb_InsertViewOnSheetsSelectedViewsCount.Location = new System.Drawing.Point(12, 208);
            this.Lb_InsertViewOnSheetsSelectedViewsCount.Name = "Lb_InsertViewOnSheetsSelectedViewsCount";
            this.Lb_InsertViewOnSheetsSelectedViewsCount.Size = new System.Drawing.Size(120, 15);
            this.Lb_InsertViewOnSheetsSelectedViewsCount.TabIndex = 25;
            this.Lb_InsertViewOnSheetsSelectedViewsCount.Text = "Quantidade de vistas ";
            this.Lb_InsertViewOnSheetsSelectedViewsCount.Click += new System.EventHandler(this.Lb_InsertViewOnSheetsSelectedViewsCount_Click);
            // 
            // Lb_InsertViewOnSheetsSelectedSheetsCount
            // 
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.AutoSize = true;
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.Location = new System.Drawing.Point(17, 391);
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.Name = "Lb_InsertViewOnSheetsSelectedSheetsCount";
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.Size = new System.Drawing.Size(120, 15);
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.TabIndex = 26;
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.Text = "Quantidade de folhas";
            this.Lb_InsertViewOnSheetsSelectedSheetsCount.Click += new System.EventHandler(this.Lb_InsertViewOnSheetsSelectedSheetsCount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label4.Location = new System.Drawing.Point(10, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Qtd de vistas selecionadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(15, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Qtd de folhas selecionadas:";
            // 
            // Form_InsertViewsOnSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(285, 472);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lb_InsertViewOnSheetsSelectedSheetsCount);
            this.Controls.Add(this.Lb_InsertViewOnSheetsSelectedViewsCount);
            this.Controls.Add(this.Cb_InsertViewsOnSheetFilterForSheetsValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cb_InsertViewOnSheetsViewParametersForSheet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_FirstTitleTipoDeVista);
            this.Controls.Add(this.Btn_InsertViewsOnSheetInsert);
            this.Controls.Add(this.Cb_InsertViewsOnSheetFilterForViewsValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cb_InsertViewOnSheetsViewParametersForView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cb_InsertViewOnSheetsViewTypeViews);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.MinimumSize = new System.Drawing.Size(270, 500);
            this.Name = "Form_InsertViewsOnSheets";
            this.Text = "INSERIR VISTAS NAS FOLHAS";
            this.Load += new System.EventHandler(this.Form_InsertViewsOnSheets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb_InsertViewOnSheetsViewTypeViews;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cb_InsertViewOnSheetsViewParametersForView;
        private System.Windows.Forms.ComboBox Cb_InsertViewsOnSheetFilterForViewsValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_InsertViewsOnSheetInsert;
        private System.Windows.Forms.Label Lb_FirstTitleTipoDeVista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_InsertViewOnSheetsViewParametersForSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_InsertViewsOnSheetFilterForSheetsValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lb_InsertViewOnSheetsSelectedViewsCount;
        private System.Windows.Forms.Label Lb_InsertViewOnSheetsSelectedSheetsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}