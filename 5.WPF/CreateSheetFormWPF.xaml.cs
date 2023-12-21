using System.Windows;

namespace CreateSheetFormWPF
{
    public partial class CreateSheetFormWPF : System.Windows.Window
    {
        public CreateSheetFormWPF()
        {
            InitializeComponent();
        }

        # region Método para lidar com o evento de clique do botão
        // 
        private void Btn_CreateSheetsWpfClick(object sender, RoutedEventArgs e)
        {
            // Lógica a ser executada quando o botão é clicado
            MessageBox.Show("Botão clicado!");
        }
        #endregion
    }
}
