using System;
using System.Collections;

namespace RevitEasy.DuplicateSheduleForm.Forms
{
    partial class DuplicateScheduleForm
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
            this.Btn_DuplicateScheduleCancel = new System.Windows.Forms.Button();
            this.Btn_DuplicateScheduleDuplicate = new System.Windows.Forms.Button();
            this.Cb_DuplicateSchedule = new System.Windows.Forms.ComboBox();
            this.Tb_DuplicateScheduleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_DuplicateScheduleNumberStarts = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Tb_DuplicateScheduleNumberEnds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_DuplicateScheduleFilterValue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_DuplicateScheduleNameSuffix = new System.Windows.Forms.TextBox();
            this.Tb_DuplicateSchedulePreffixFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_DuplicateScheduleSuffixFilter = new System.Windows.Forms.TextBox();
            this.Cb_ScheduleFilterType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_DuplicateScheduleCancel
            // 
            this.Btn_DuplicateScheduleCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Btn_DuplicateScheduleCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DuplicateScheduleCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Btn_DuplicateScheduleCancel.Location = new System.Drawing.Point(28, 483);
            this.Btn_DuplicateScheduleCancel.Name = "Btn_DuplicateScheduleCancel";
            this.Btn_DuplicateScheduleCancel.Size = new System.Drawing.Size(90, 25);
            this.Btn_DuplicateScheduleCancel.TabIndex = 10;
            this.Btn_DuplicateScheduleCancel.Text = "Cancelar";
            this.Btn_DuplicateScheduleCancel.UseVisualStyleBackColor = false;
            this.Btn_DuplicateScheduleCancel.Click += new System.EventHandler(this.Btn_DuplicateScheduleCancel_Click);
            // 
            // Btn_DuplicateScheduleDuplicate
            // 
            this.Btn_DuplicateScheduleDuplicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Btn_DuplicateScheduleDuplicate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DuplicateScheduleDuplicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Btn_DuplicateScheduleDuplicate.Location = new System.Drawing.Point(129, 483);
            this.Btn_DuplicateScheduleDuplicate.Name = "Btn_DuplicateScheduleDuplicate";
            this.Btn_DuplicateScheduleDuplicate.Size = new System.Drawing.Size(90, 25);
            this.Btn_DuplicateScheduleDuplicate.TabIndex = 10;
            this.Btn_DuplicateScheduleDuplicate.Text = "Duplicar";
            this.Btn_DuplicateScheduleDuplicate.UseVisualStyleBackColor = false;
            this.Btn_DuplicateScheduleDuplicate.Click += new System.EventHandler(this.Btn_DuplicateScheduleDuplicate_Click);
            // 
            // Cb_DuplicateSchedule
            // 
            this.Cb_DuplicateSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_DuplicateSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_DuplicateSchedule.FormattingEnabled = true;
            this.Cb_DuplicateSchedule.Location = new System.Drawing.Point(20, 37);
            this.Cb_DuplicateSchedule.Name = "Cb_DuplicateSchedule";
            this.Cb_DuplicateSchedule.Size = new System.Drawing.Size(210, 21);
            this.Cb_DuplicateSchedule.TabIndex = 1;
            this.Cb_DuplicateSchedule.SelectedIndexChanged += new System.EventHandler(this.Sic_DuplicateSchedule);
            // 
            // Tb_DuplicateScheduleName
            // 
            this.Tb_DuplicateScheduleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_DuplicateScheduleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_DuplicateScheduleName.Location = new System.Drawing.Point(20, 88);
            this.Tb_DuplicateScheduleName.Name = "Tb_DuplicateScheduleName";
            this.Tb_DuplicateScheduleName.Size = new System.Drawing.Size(210, 20);
            this.Tb_DuplicateScheduleName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome da tabela";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label4.Location = new System.Drawing.Point(15, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome do filtro que será preenchido";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(15, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número da primeira tabela";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tb_DuplicateScheduleNumberStarts
            // 
            this.Tb_DuplicateScheduleNumberStarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_DuplicateScheduleNumberStarts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_DuplicateScheduleNumberStarts.Location = new System.Drawing.Point(20, 191);
            this.Tb_DuplicateScheduleNumberStarts.Name = "Tb_DuplicateScheduleNumberStarts";
            this.Tb_DuplicateScheduleNumberStarts.Size = new System.Drawing.Size(210, 20);
            this.Tb_DuplicateScheduleNumberStarts.TabIndex = 4;
            this.Tb_DuplicateScheduleNumberStarts.TextChanged += new System.EventHandler(this.Tb_DuplicateScheduleNumberStarts_TextChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Title.Location = new System.Drawing.Point(15, 220);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(136, 15);
            this.Title.TabIndex = 14;
            this.Title.Text = "Número da útima tabela";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tb_DuplicateScheduleNumberEnds
            // 
            this.Tb_DuplicateScheduleNumberEnds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_DuplicateScheduleNumberEnds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_DuplicateScheduleNumberEnds.Location = new System.Drawing.Point(20, 241);
            this.Tb_DuplicateScheduleNumberEnds.Name = "Tb_DuplicateScheduleNumberEnds";
            this.Tb_DuplicateScheduleNumberEnds.Size = new System.Drawing.Size(210, 20);
            this.Tb_DuplicateScheduleNumberEnds.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tabela que será duplicada";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cb_DuplicateScheduleFilterValue
            // 
            this.Cb_DuplicateScheduleFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_DuplicateScheduleFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_DuplicateScheduleFilterValue.FormattingEnabled = true;
            this.Cb_DuplicateScheduleFilterValue.Location = new System.Drawing.Point(20, 339);
            this.Cb_DuplicateScheduleFilterValue.Name = "Cb_DuplicateScheduleFilterValue";
            this.Cb_DuplicateScheduleFilterValue.Size = new System.Drawing.Size(210, 21);
            this.Cb_DuplicateScheduleFilterValue.TabIndex = 7;
            this.Cb_DuplicateScheduleFilterValue.SelectedIndexChanged += new System.EventHandler(this.Sic_FieldSelect);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(15, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sufixo do nome da tabela";
            // 
            // Tb_DuplicateScheduleNameSuffix
            // 
            this.Tb_DuplicateScheduleNameSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_DuplicateScheduleNameSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_DuplicateScheduleNameSuffix.Location = new System.Drawing.Point(20, 139);
            this.Tb_DuplicateScheduleNameSuffix.Name = "Tb_DuplicateScheduleNameSuffix";
            this.Tb_DuplicateScheduleNameSuffix.Size = new System.Drawing.Size(210, 20);
            this.Tb_DuplicateScheduleNameSuffix.TabIndex = 3;
            // 
            // Tb_DuplicateSchedulePreffixFilter
            // 
            this.Tb_DuplicateSchedulePreffixFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_DuplicateSchedulePreffixFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_DuplicateSchedulePreffixFilter.Location = new System.Drawing.Point(20, 290);
            this.Tb_DuplicateSchedulePreffixFilter.Name = "Tb_DuplicateSchedulePreffixFilter";
            this.Tb_DuplicateSchedulePreffixFilter.Size = new System.Drawing.Size(210, 20);
            this.Tb_DuplicateSchedulePreffixFilter.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(15, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prefixo do filtro";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label7.Location = new System.Drawing.Point(15, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sufixo do filtro";
            // 
            // Tb_DuplicateScheduleSuffixFilter
            // 
            this.Tb_DuplicateScheduleSuffixFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_DuplicateScheduleSuffixFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_DuplicateScheduleSuffixFilter.Location = new System.Drawing.Point(20, 444);
            this.Tb_DuplicateScheduleSuffixFilter.Name = "Tb_DuplicateScheduleSuffixFilter";
            this.Tb_DuplicateScheduleSuffixFilter.Size = new System.Drawing.Size(210, 20);
            this.Tb_DuplicateScheduleSuffixFilter.TabIndex = 9;
            // 
            // Cb_ScheduleFilterType
            // 
            this.Cb_ScheduleFilterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Cb_ScheduleFilterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Cb_ScheduleFilterType.FormattingEnabled = true;
            this.Cb_ScheduleFilterType.Location = new System.Drawing.Point(20, 395);
            this.Cb_ScheduleFilterType.Name = "Cb_ScheduleFilterType";
            this.Cb_ScheduleFilterType.Size = new System.Drawing.Size(210, 21);
            this.Cb_ScheduleFilterType.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label8.Location = new System.Drawing.Point(15, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tipo filtro que será preenchido";
            // 
            // DuplicateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(254, 561);
            this.Controls.Add(this.Cb_ScheduleFilterType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tb_DuplicateScheduleSuffixFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tb_DuplicateScheduleNameSuffix);
            this.Controls.Add(this.Cb_DuplicateScheduleFilterValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Tb_DuplicateScheduleNumberEnds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_DuplicateScheduleNumberStarts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_DuplicateSchedulePreffixFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_DuplicateScheduleName);
            this.Controls.Add(this.Cb_DuplicateSchedule);
            this.Controls.Add(this.Btn_DuplicateScheduleDuplicate);
            this.Controls.Add(this.Btn_DuplicateScheduleCancel);
            this.MinimumSize = new System.Drawing.Size(270, 600);
            this.Name = "DuplicateScheduleForm";
            this.Text = "Duplicar tabelas";
            this.Load += new System.EventHandler(this.DuplicateScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button Btn_DuplicateScheduleCancel;
        private System.Windows.Forms.Button Btn_DuplicateScheduleDuplicate;
        private System.Windows.Forms.ComboBox Cb_DuplicateSchedule;
        private System.Windows.Forms.TextBox Tb_DuplicateScheduleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_DuplicateScheduleNumberStarts;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Tb_DuplicateScheduleNumberEnds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_DuplicateScheduleFilterValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_DuplicateScheduleNameSuffix;
        private System.Windows.Forms.TextBox Tb_DuplicateSchedulePreffixFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_DuplicateScheduleSuffixFilter;
        private System.Windows.Forms.ComboBox Cb_ScheduleFilterType;
        private System.Windows.Forms.Label label8;
    }
}