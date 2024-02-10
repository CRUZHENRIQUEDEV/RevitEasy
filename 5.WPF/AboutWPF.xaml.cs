using RevitEasy.WPF.Behaviors;
using System;
using System.Windows;
using System.Windows.Navigation;

namespace RevitEasy._5.WPF
{
    public partial class AboutWPF : Window
    {
        public AboutWPF()
        {
            InitializeComponent();
            RevitFormBehavior.Register(this); // Comportamento comum a todos os formulários
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        // Adicione outros manipuladores de eventos conforme necessário
    }
}
