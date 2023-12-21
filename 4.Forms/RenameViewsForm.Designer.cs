namespace RevitEasy.RenameViews.Forms
{
    partial class Wf_RenameViews
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
            this.Tb_RenameViewNamePreffix = new System.Windows.Forms.TextBox();
            this.Tb_RenameViewNameNumberStarts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_RenameViewNameSuffix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_RenameViewsType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cb_RenameViewsInstanceParameters = new System.Windows.Forms.ComboBox();
            this.Cb_RenameViewsFilterValue = new System.Windows.Forms.ComboBox();
            this.Btn_ViewNameRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_RenameViewNamePreffix
            // 
            this.Tb_RenameViewNamePreffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_RenameViewNamePreffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_RenameViewNamePreffix.Location = new System.Drawing.Point(15, 231);
            this.Tb_RenameViewNamePreffix.Name = "Tb_RenameViewNamePreffix";
            this.Tb_RenameViewNamePreffix.Size = new System.Drawing.Size(220, 20);
            this.Tb_RenameViewNamePreffix.TabIndex = 4;
            this.Tb_RenameViewNamePreffix.TextChanged += new System.EventHandler(this.Tb_RenameViewNamePreffix_TextChanged);
            this.Tb_RenameViewNamePreffix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kp_RenameViewNamePreffix);
            // 
            // Tb_RenameViewNameNumberStarts
            // 
            this.Tb_RenameViewNameNumberStarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_RenameViewNameNumberStarts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_RenameViewNameNumberStarts.Location = new System.Drawing.Point(15, 284);
            this.Tb_RenameViewNameNumberStarts.Name = "Tb_RenameViewNameNumberStarts";
            this.Tb_RenameViewNameNumberStarts.Size = new System.Drawing.Size(220, 20);
            this.Tb_RenameViewNameNumberStarts.TabIndex = 5;
            this.Tb_RenameViewNameNumberStarts.TextChanged += new System.EventHandler(this.Tb_RenameViewNameNumberStarts_TextChanged);
            this.Tb_RenameViewNameNumberStarts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kp_RenameViewNameNumberStarts);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(10, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prefixo + nome da vista";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tb_RenameViewNameSuffix
            // 
            this.Tb_RenameViewNameSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_RenameViewNameSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_RenameViewNameSuffix.Location = new System.Drawing.Point(13, 334);
            this.Tb_RenameViewNameSuffix.Name = "Tb_RenameViewNameSuffix";
            this.Tb_RenameViewNameSuffix.Size = new System.Drawing.Size(220, 20);
            this.Tb_RenameViewNameSuffix.TabIndex = 6;
            this.Tb_RenameViewNameSuffix.TextChanged += new System.EventHandler(this.Tb_RenameViewNameSuffix_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(10, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número da primeira vista";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label4.Location = new System.Drawing.Point(8, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sufíxo do nome da vista";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filtrar vistas pelo valor...";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de vista";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Cb_RenameViewsType
            // 
            this.Cb_RenameViewsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_RenameViewsType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_RenameViewsType.FormattingEnabled = true;
            this.Cb_RenameViewsType.Location = new System.Drawing.Point(15, 50);
            this.Cb_RenameViewsType.Name = "Cb_RenameViewsType";
            this.Cb_RenameViewsType.Size = new System.Drawing.Size(220, 21);
            this.Cb_RenameViewsType.TabIndex = 1;
            this.Cb_RenameViewsType.Text = "Ex: Planta de piso";
            this.Cb_RenameViewsType.SelectedIndexChanged += new System.EventHandler(this.Sic_RenameViewsType);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label7.Location = new System.Drawing.Point(10, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome do parametro para filtrar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Cb_RenameViewsInstanceParameters
            // 
            this.Cb_RenameViewsInstanceParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_RenameViewsInstanceParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_RenameViewsInstanceParameters.FormattingEnabled = true;
            this.Cb_RenameViewsInstanceParameters.Location = new System.Drawing.Point(12, 108);
            this.Cb_RenameViewsInstanceParameters.Name = "Cb_RenameViewsInstanceParameters";
            this.Cb_RenameViewsInstanceParameters.Size = new System.Drawing.Size(220, 21);
            this.Cb_RenameViewsInstanceParameters.TabIndex = 2;
            this.Cb_RenameViewsInstanceParameters.Text = "Ex:Marca";
            this.Cb_RenameViewsInstanceParameters.SelectedIndexChanged += new System.EventHandler(this.Cb_RenameViewsInstanceParameters_SelectedIndexChanged);
            // 
            // Cb_RenameViewsFilterValue
            // 
            this.Cb_RenameViewsFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_RenameViewsFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_RenameViewsFilterValue.FormattingEnabled = true;
            this.Cb_RenameViewsFilterValue.Location = new System.Drawing.Point(12, 161);
            this.Cb_RenameViewsFilterValue.Name = "Cb_RenameViewsFilterValue";
            this.Cb_RenameViewsFilterValue.Size = new System.Drawing.Size(220, 21);
            this.Cb_RenameViewsFilterValue.TabIndex = 3;
            this.Cb_RenameViewsFilterValue.SelectedIndexChanged += new System.EventHandler(this.Cb_RenameViewsFilterValue_SelectedIndexChanged);
            // 
            // Btn_ViewNameRename
            // 
            this.Btn_ViewNameRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Btn_ViewNameRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewNameRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Btn_ViewNameRename.Location = new System.Drawing.Point(110, 363);
            this.Btn_ViewNameRename.Name = "Btn_ViewNameRename";
            this.Btn_ViewNameRename.Size = new System.Drawing.Size(110, 30);
            this.Btn_ViewNameRename.TabIndex = 10;
            this.Btn_ViewNameRename.Text = "Renomear";
            this.Btn_ViewNameRename.UseVisualStyleBackColor = false;
            this.Btn_ViewNameRename.Click += new System.EventHandler(this.Btn_ViewNameRename_Click);
            // 
            // Wf_RenameViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(244, 401);
            this.Controls.Add(this.Cb_RenameViewsFilterValue);
            this.Controls.Add(this.Cb_RenameViewsInstanceParameters);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cb_RenameViewsType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_ViewNameRename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_RenameViewNameSuffix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_RenameViewNameNumberStarts);
            this.Controls.Add(this.Tb_RenameViewNamePreffix);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.MinimumSize = new System.Drawing.Size(260, 440);
            this.Name = "Wf_RenameViews";
            this.Text = " RENOMEAR VISTAS";
            this.Load += new System.EventHandler(this.Ld_RenameViews);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_RenameViewNamePreffix;
        private System.Windows.Forms.TextBox Tb_RenameViewNameNumberStarts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_RenameViewNameSuffix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_RenameViewsType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cb_RenameViewsInstanceParameters;
        private System.Windows.Forms.ComboBox Cb_RenameViewsFilterValue;
        private System.Windows.Forms.Button Btn_ViewNameRename;
    }
}