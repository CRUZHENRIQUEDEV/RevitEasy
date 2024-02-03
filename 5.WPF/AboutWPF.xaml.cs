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
    /// Interação lógica para AboutWPF.xam
    /// </summary>
    public partial class AboutWPF : Window
    {
        public AboutWPF()
        {
            InitializeComponent();
        }

        #region Minimize, Restore, Close window buttons

        private void Btn_MinimizeClick(object sender, RoutedEventArgs e)
        {

            // Minimiza o formulário
            this.WindowState = WindowState.Minimized;
        }

        private void Btn_RestoreClick(object sender, RoutedEventArgs e)
        {
            // Verifica se o formulário está maximizado
            if (this.WindowState == WindowState.Maximized)
            {
                // Restaura para o tamanho normal
                this.WindowState = WindowState.Normal;
            }
            else
            {
                // Maximiza o formulário
                this.WindowState = WindowState.Maximized;
            }
        }

        private void Btn_CloseClick(object sender, RoutedEventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }


        #endregion
    }


}
