namespace RevitEasy.CoatingCalculateForm
{
    partial class CoatingCalculateForm
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
            this.Tb_CoatingCalculateRoomSideA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_CoatingCalculateRoomSideB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_CoatingCalculateCoatingSideB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_CoatingCalculateCoatingSideA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lb_CoatingCalculateCoatingAreaWatch = new System.Windows.Forms.Label();
            this.Lb_CoatingCalculateRoomAreaWatch = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_CoatingCalculateCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_CoatingCalculateRoomSideA
            // 
            this.Tb_CoatingCalculateRoomSideA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_CoatingCalculateRoomSideA.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Tb_CoatingCalculateRoomSideA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_CoatingCalculateRoomSideA.Location = new System.Drawing.Point(16, 53);
            this.Tb_CoatingCalculateRoomSideA.Name = "Tb_CoatingCalculateRoomSideA";
            this.Tb_CoatingCalculateRoomSideA.Size = new System.Drawing.Size(79, 23);
            this.Tb_CoatingCalculateRoomSideA.TabIndex = 1;
            this.Tb_CoatingCalculateRoomSideA.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(102, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "M²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(102, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "M²";
            // 
            // Tb_CoatingCalculateRoomSideB
            // 
            this.Tb_CoatingCalculateRoomSideB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_CoatingCalculateRoomSideB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Tb_CoatingCalculateRoomSideB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_CoatingCalculateRoomSideB.Location = new System.Drawing.Point(16, 95);
            this.Tb_CoatingCalculateRoomSideB.Name = "Tb_CoatingCalculateRoomSideB";
            this.Tb_CoatingCalculateRoomSideB.Size = new System.Drawing.Size(79, 23);
            this.Tb_CoatingCalculateRoomSideB.TabIndex = 2;
            this.Tb_CoatingCalculateRoomSideB.Text = "1";
            this.Tb_CoatingCalculateRoomSideB.TextChanged += new System.EventHandler(this.SicCoatingCalculateRoomSideB);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área do ambiente";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label4.Location = new System.Drawing.Point(102, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "M";
            // 
            // Tb_CoatingCalculateCoatingSideB
            // 
            this.Tb_CoatingCalculateCoatingSideB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_CoatingCalculateCoatingSideB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Tb_CoatingCalculateCoatingSideB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_CoatingCalculateCoatingSideB.Location = new System.Drawing.Point(16, 277);
            this.Tb_CoatingCalculateCoatingSideB.Name = "Tb_CoatingCalculateCoatingSideB";
            this.Tb_CoatingCalculateCoatingSideB.Size = new System.Drawing.Size(79, 23);
            this.Tb_CoatingCalculateCoatingSideB.TabIndex = 4;
            this.Tb_CoatingCalculateCoatingSideB.TextChanged += new System.EventHandler(this.Sic_CoatingCalculateCoatingArea);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label5.Location = new System.Drawing.Point(102, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "M";
            // 
            // Tb_CoatingCalculateCoatingSideA
            // 
            this.Tb_CoatingCalculateCoatingSideA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Tb_CoatingCalculateCoatingSideA.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Tb_CoatingCalculateCoatingSideA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Tb_CoatingCalculateCoatingSideA.Location = new System.Drawing.Point(16, 232);
            this.Tb_CoatingCalculateCoatingSideA.Name = "Tb_CoatingCalculateCoatingSideA";
            this.Tb_CoatingCalculateCoatingSideA.Size = new System.Drawing.Size(79, 23);
            this.Tb_CoatingCalculateCoatingSideA.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(4, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dimensões da peça";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label7.Location = new System.Drawing.Point(46, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "x";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label8.Location = new System.Drawing.Point(46, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label9.Location = new System.Drawing.Point(6, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Qtd. Aproximada:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // Lb_CoatingCalculateCoatingAreaWatch
            // 
            this.Lb_CoatingCalculateCoatingAreaWatch.AutoSize = true;
            this.Lb_CoatingCalculateCoatingAreaWatch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Lb_CoatingCalculateCoatingAreaWatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Lb_CoatingCalculateCoatingAreaWatch.Location = new System.Drawing.Point(6, 323);
            this.Lb_CoatingCalculateCoatingAreaWatch.Name = "Lb_CoatingCalculateCoatingAreaWatch";
            this.Lb_CoatingCalculateCoatingAreaWatch.Size = new System.Drawing.Size(133, 15);
            this.Lb_CoatingCalculateCoatingAreaWatch.TabIndex = 13;
            this.Lb_CoatingCalculateCoatingAreaWatch.Text = "Qtd. Aproximada watch";
            // 
            // Lb_CoatingCalculateRoomAreaWatch
            // 
            this.Lb_CoatingCalculateRoomAreaWatch.AutoSize = true;
            this.Lb_CoatingCalculateRoomAreaWatch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Lb_CoatingCalculateRoomAreaWatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Lb_CoatingCalculateRoomAreaWatch.Location = new System.Drawing.Point(7, 149);
            this.Lb_CoatingCalculateRoomAreaWatch.Name = "Lb_CoatingCalculateRoomAreaWatch";
            this.Lb_CoatingCalculateRoomAreaWatch.Size = new System.Drawing.Size(139, 15);
            this.Lb_CoatingCalculateRoomAreaWatch.TabIndex = 15;
            this.Lb_CoatingCalculateRoomAreaWatch.Text = "Área do ambiente Watch";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label12.Location = new System.Drawing.Point(7, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Área do ambiente";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // Btn_CoatingCalculateCalculate
            // 
            this.Btn_CoatingCalculateCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Btn_CoatingCalculateCalculate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_CoatingCalculateCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Btn_CoatingCalculateCalculate.Location = new System.Drawing.Point(46, 374);
            this.Btn_CoatingCalculateCalculate.Name = "Btn_CoatingCalculateCalculate";
            this.Btn_CoatingCalculateCalculate.Size = new System.Drawing.Size(90, 25);
            this.Btn_CoatingCalculateCalculate.TabIndex = 5;
            this.Btn_CoatingCalculateCalculate.Text = "Calcular";
            this.Btn_CoatingCalculateCalculate.UseVisualStyleBackColor = false;
            this.Btn_CoatingCalculateCalculate.Click += new System.EventHandler(this.Btn_CoatingCalculateCalculate_Click);
            // 
            // CoatingCalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Btn_CoatingCalculateCalculate);
            this.Controls.Add(this.Lb_CoatingCalculateRoomAreaWatch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Lb_CoatingCalculateCoatingAreaWatch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_CoatingCalculateCoatingSideB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tb_CoatingCalculateCoatingSideA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_CoatingCalculateRoomSideB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_CoatingCalculateRoomSideA);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(188)))));
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "CoatingCalculateForm";
            this.Text = "CALCULADORA DE PEÇAS DE REVESTIMENTO";
            this.Load += new System.EventHandler(this.CoatingCalculatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tb_CoatingCalculateRoomSideA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_CoatingCalculateRoomSideB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_CoatingCalculateCoatingSideB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_CoatingCalculateCoatingSideA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lb_CoatingCalculateCoatingAreaWatch;
        private System.Windows.Forms.Label Lb_CoatingCalculateRoomAreaWatch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_CoatingCalculateCalculate;
    }
}