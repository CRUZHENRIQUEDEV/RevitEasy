﻿using RevitEasy.WPF.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RevitEasy._5.WPF
{
    /// <summary>
    /// Interação lógica para RenumberSheetsFormWPF.xam
    /// </summary>
    public partial class RenumberSheetsFormWPF : Window
    {
        public RenumberSheetsFormWPF()
        {
            InitializeComponent();
            RevitFormBehavior.Register(this); //back common to all forms
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}