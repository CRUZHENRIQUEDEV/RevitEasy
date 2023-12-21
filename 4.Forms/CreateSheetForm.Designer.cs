using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace RevitEasy.DuplicateSheduleForm.Forms
{
    public partial class CreateSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSheetForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Sheet_name_preffix = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sheet_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sheet_name_suffix = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sheet_number_preffix = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sheet_number_starts = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sheet_number_ends = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sheet_number_suffix = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.sheet_titleBlock = new System.Windows.Forms.ComboBox();
            this.Btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label.Name = "label";
            this.label.Click += new System.EventHandler(this.Label_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.label10.Name = "label10";
            // 
            // Sheet_name_preffix
            // 
            this.Sheet_name_preffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name_preffix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Sheet_name_preffix.BorderRadius = 5;
            this.Sheet_name_preffix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sheet_name_preffix.DefaultText = "";
            this.Sheet_name_preffix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sheet_name_preffix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sheet_name_preffix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_name_preffix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_name_preffix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name_preffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Sheet_name_preffix, "Sheet_name_preffix");
            this.Sheet_name_preffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Sheet_name_preffix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sheet_name_preffix.Name = "Sheet_name_preffix";
            this.Sheet_name_preffix.PasswordChar = '\0';
            this.Sheet_name_preffix.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name_preffix.PlaceholderText = "Prefixo";
            this.Sheet_name_preffix.SelectedText = "";
            this.Sheet_name_preffix.TextChanged += new System.EventHandler(this.Sheet_name_preffix_TextChanged_1);
            // 
            // Sheet_name
            // 
            this.Sheet_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Sheet_name.BorderRadius = 5;
            this.Sheet_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sheet_name.DefaultText = "";
            this.Sheet_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sheet_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sheet_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Sheet_name, "Sheet_name");
            this.Sheet_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Sheet_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sheet_name.Name = "Sheet_name";
            this.Sheet_name.PasswordChar = '\0';
            this.Sheet_name.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name.PlaceholderText = "Ex: PAREDE";
            this.Sheet_name.SelectedText = "";
            this.Sheet_name.TextChanged += new System.EventHandler(this.Sheet_name_TextChanged_1);
            // 
            // Sheet_name_suffix
            // 
            this.Sheet_name_suffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name_suffix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Sheet_name_suffix.BorderRadius = 5;
            this.Sheet_name_suffix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sheet_name_suffix.DefaultText = "";
            this.Sheet_name_suffix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sheet_name_suffix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sheet_name_suffix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_name_suffix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_name_suffix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name_suffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Sheet_name_suffix, "Sheet_name_suffix");
            this.Sheet_name_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Sheet_name_suffix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sheet_name_suffix.Name = "Sheet_name_suffix";
            this.Sheet_name_suffix.PasswordChar = '\0';
            this.Sheet_name_suffix.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_name_suffix.PlaceholderText = "EX:  A";
            this.Sheet_name_suffix.SelectedText = "";
            this.Sheet_name_suffix.Enter += new System.EventHandler(this.Sheet_name_suffix_Enter);
            this.Sheet_name_suffix.Leave += new System.EventHandler(this.Sheet_name_suffix_Leave);
            // 
            // Sheet_number_preffix
            // 
            this.Sheet_number_preffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_preffix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Sheet_number_preffix.BorderRadius = 5;
            this.Sheet_number_preffix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sheet_number_preffix.DefaultText = "";
            this.Sheet_number_preffix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sheet_number_preffix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sheet_number_preffix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_preffix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_preffix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_preffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Sheet_number_preffix, "Sheet_number_preffix");
            this.Sheet_number_preffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Sheet_number_preffix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sheet_number_preffix.Name = "Sheet_number_preffix";
            this.Sheet_number_preffix.PasswordChar = '\0';
            this.Sheet_number_preffix.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_preffix.PlaceholderText = "Prefixo";
            this.Sheet_number_preffix.SelectedText = "";
            this.Sheet_number_preffix.TextChanged += new System.EventHandler(this.Sheet_number_preffix_TextChanged);
            this.Sheet_number_preffix.Enter += new System.EventHandler(this.Sheet_number_preffix_Enter);
            this.Sheet_number_preffix.Leave += new System.EventHandler(this.Sheet_number_preffix_Leave);
            // 
            // Sheet_number_starts
            // 
            this.Sheet_number_starts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_starts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Sheet_number_starts.BorderRadius = 5;
            this.Sheet_number_starts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sheet_number_starts.DefaultText = "";
            this.Sheet_number_starts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sheet_number_starts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sheet_number_starts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_starts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_starts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_starts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Sheet_number_starts, "Sheet_number_starts");
            this.Sheet_number_starts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Sheet_number_starts.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sheet_number_starts.Name = "Sheet_number_starts";
            this.Sheet_number_starts.PasswordChar = '\0';
            this.Sheet_number_starts.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_starts.PlaceholderText = "Digite um número inteiro";
            this.Sheet_number_starts.SelectedText = "";
            this.Sheet_number_starts.TextChanged += new System.EventHandler(this.Sheet_number_starts_TextChanged);
            this.Sheet_number_starts.Enter += new System.EventHandler(this.Sheet_number_starts_Enter);
            this.Sheet_number_starts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sheet_number_starts_KeyPress);
            this.Sheet_number_starts.Leave += new System.EventHandler(this.Sheet_number_starts_Leave);
            // 
            // Sheet_number_ends
            // 
            this.Sheet_number_ends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_ends.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Sheet_number_ends.BorderRadius = 5;
            this.Sheet_number_ends.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sheet_number_ends.DefaultText = "";
            this.Sheet_number_ends.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sheet_number_ends.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sheet_number_ends.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_ends.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_ends.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_ends.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Sheet_number_ends, "Sheet_number_ends");
            this.Sheet_number_ends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Sheet_number_ends.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sheet_number_ends.Name = "Sheet_number_ends";
            this.Sheet_number_ends.PasswordChar = '\0';
            this.Sheet_number_ends.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_ends.PlaceholderText = "Digite um número inteiro";
            this.Sheet_number_ends.SelectedText = "";
            this.Sheet_number_ends.ShortcutsEnabled = false;
            this.Sheet_number_ends.TextChanged += new System.EventHandler(this.Sheet_number_ends_TextChanged);
            this.Sheet_number_ends.Enter += new System.EventHandler(this.Sheet_number_preffix_Enter);
            this.Sheet_number_ends.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sheet_number_ends_KeyPress);
            this.Sheet_number_ends.Leave += new System.EventHandler(this.Sheet_number_ends_Leave);
            // 
            // Sheet_number_suffix
            // 
            this.Sheet_number_suffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_suffix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Sheet_number_suffix.BorderRadius = 5;
            this.Sheet_number_suffix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sheet_number_suffix.DefaultText = "";
            this.Sheet_number_suffix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sheet_number_suffix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sheet_number_suffix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_suffix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sheet_number_suffix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_suffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Sheet_number_suffix, "Sheet_number_suffix");
            this.Sheet_number_suffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Sheet_number_suffix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sheet_number_suffix.Name = "Sheet_number_suffix";
            this.Sheet_number_suffix.PasswordChar = '\0';
            this.Sheet_number_suffix.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.Sheet_number_suffix.PlaceholderText = "Sufixo";
            this.Sheet_number_suffix.SelectedText = "";
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.Btn_cancel.BorderColor = System.Drawing.Color.White;
            this.Btn_cancel.BorderThickness = 1;
            this.Btn_cancel.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.Btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.Btn_cancel, "Btn_cancel");
            this.Btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(172)))));
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_CancelClick);
            // 
            // sheet_titleBlock
            // 
            this.sheet_titleBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.sheet_titleBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.sheet_titleBlock.FormattingEnabled = true;
            resources.ApplyResources(this.sheet_titleBlock, "sheet_titleBlock");
            this.sheet_titleBlock.Name = "sheet_titleBlock";
            this.sheet_titleBlock.SelectedIndexChanged += new System.EventHandler(this.Sheet_titleBlock_SelectedIndexChanged_1);
            // 
            // Btn_create
            // 
            this.Btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            resources.ApplyResources(this.Btn_create, "Btn_create");
            this.Btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Btn_create.Name = "Btn_create";
            this.Btn_create.UseVisualStyleBackColor = false;
            this.Btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // CreateSheetForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.Btn_create);
            this.Controls.Add(this.sheet_titleBlock);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Sheet_number_suffix);
            this.Controls.Add(this.Sheet_number_ends);
            this.Controls.Add(this.Sheet_number_starts);
            this.Controls.Add(this.Sheet_number_preffix);
            this.Controls.Add(this.Sheet_name_suffix);
            this.Controls.Add(this.Sheet_name);
            this.Controls.Add(this.Sheet_name_preffix);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateSheetForm";
            this.Load += new System.EventHandler(this.CreateSheetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox Sheet_name_preffix;
        private Guna.UI2.WinForms.Guna2TextBox Sheet_name;
        private Guna.UI2.WinForms.Guna2TextBox Sheet_name_suffix;
        private Guna.UI2.WinForms.Guna2TextBox Sheet_number_preffix;
        private Guna.UI2.WinForms.Guna2TextBox Sheet_number_starts;
        private Guna.UI2.WinForms.Guna2TextBox Sheet_number_ends;
        private Guna.UI2.WinForms.Guna2TextBox Sheet_number_suffix;
        private Guna.UI2.WinForms.Guna2Button Btn_cancel;
        private System.Windows.Forms.ComboBox sheet_titleBlock;
        private Button Btn_create;
    }
}