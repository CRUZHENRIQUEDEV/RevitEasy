using Autodesk.Revit.DB;
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
using Autodesk.Revit.UI;
using RevitEasy.LoadViewTypes;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace RevitEasy.InsertViewsOnSheetsWPF
{
    public partial class InsertViewsOnSheetsFormWPF : Window
    {
    private readonly Document doc;

        private readonly ViewTypeManager viewTypeManager;
        public InsertViewsOnSheetsFormWPF(Document document)
        {
            InitializeComponent();
            doc = document; // Inicializa o documento
            viewTypeManager = new ViewTypeManager(doc); // Adiciona a instância do ViewTypeManager                                            
            
        }


        private void InsertViewsOnSheetsFormWPF_Loaded(object sender, RoutedEventArgs e)
        {
            // Coloque o código que você deseja executar ao carregar o formulário aqui
            // Exemplo: LoadViewTypes();
            // ...
        }

        #region Acão executada quando o botão sair é clicado
        private void Btn_RenameViewsExit_Click(object sender, RoutedEventArgs e)
        {
            //Acão executada quando o botão sair é clicado

            // Fecha o formulário
            this.Close();
        }
        #endregion

    }
}
