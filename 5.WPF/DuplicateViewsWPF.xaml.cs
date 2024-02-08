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

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitPoint = Autodesk.Revit.DB.Point;


namespace RevitEasy._5.WPF
{
    /// <summary>
    /// Interação lógica para DuplicateViewsWPF.xam
    /// </summary>
    public partial class DuplicateViewsWPF :Window
    {

        #region Método para mover janela com o mouse ao clicar e arrastar
        private bool isDragging = false;
        private System.Windows.Point startPoint;


        private void FormWPF_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = true;
                startPoint = e.GetPosition(this);
            }
        }
        private void FormWPF_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (isDragging && e.LeftButton == MouseButtonState.Pressed)
            {
                System.Windows.Point currentPosition = e.GetPosition(this);
                double deltaX = currentPosition.X - startPoint.X;
                double deltaY = currentPosition.Y - startPoint.Y;

                this.Left += deltaX;
                this.Top += deltaY;
            }
        }
        private void FormWPF_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = false;
            }
        }

        #endregion

        private readonly Document doc;

        public DuplicateViewsWPF(Document document)
        {
            InitializeComponent();
            doc = document; // Initialize the document
            Loaded += DuplicateViewsWPF_Loaded;
            
        }


        #region Methods called when the form is loaded

        private void DuplicateViewsWPF_Loaded(object sender, RoutedEventArgs e)
        {

        // Load all views in the model
        LoadViewsInModel();
        }


        #endregion

        #region Methods to load views in the model

        private void LoadViewsInModel()
        {
            try
            {
                // Get all views in the model
                IList<View> allViews = GetAllViewsInModel();

                // Display views in the ComboBox
                DisplayViewsInComboBox(allViews);
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully
                ShowErrorMessage("Error loading views in the model", ex.Message);
            }
        }

        private IList<View> GetAllViewsInModel()
        {
            // Use a filtered element collector to get all views in the model
            return new FilteredElementCollector(doc)
                .OfClass(typeof(View))
                .Cast<View>()
                .ToList();
        }

        private void DisplayViewsInComboBox(IList<View> views)
        {
            // Clear existing items in the ComboBox
            Cb_DuplicateViewSelect.Items.Clear();

            // Add views to the ComboBox
            foreach (View view in views)
            {
                Cb_DuplicateViewSelect.Items.Add(view.Name);
            }

            // If there are items, select the first one
            if (Cb_DuplicateViewSelect.Items.Count > 0)
            {
                Cb_DuplicateViewSelect.SelectedIndex = 0;
            }
        }

        private void ShowErrorMessage(string title, string errorMessage)
        {
            // Display an error message in a message box
            MessageBox.Show(errorMessage, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        #endregion

        #region Methods to receive form inputs and duplicate views

        private void Btn_create_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected view in the ComboBox
            string selectedViewName = Cb_DuplicateViewSelect.SelectedItem?.ToString();
            View selectedView = GetViewInModel(selectedViewName);

            // Verify if required fields are filled
            if (selectedView == null)
            {
                TaskDialog.Show("Empty Fields", "Select a view to duplicate.");
            }
            else
            {
                // Get the amount from the TextBox
                if (int.TryParse(Lb_DuplicateViewsAmout.Text, out int numberOfViews))
                {
                    // Create a transaction group for view duplication
                    using (TransactionGroup group = new TransactionGroup(doc, "Duplicate Views"))
                    {
                        group.Start();

                        try
                        {
                            // Duplicate multiple views in Revit
                            DuplicateMultipleViews(selectedView, numberOfViews);

                            // Commit the group transaction
                            group.Assimilate();
                        }
                        catch (Exception ex)
                        {
                            // If there is an error, roll back the group transaction
                            group.RollBack();
                            TaskDialog.Show("Error", ex.Message);
                        }
                    }
                }
                else
                {
                    TaskDialog.Show("Invalid Input", "Please enter a valid number for the amount of views to duplicate.");
                }
            }
        }

        private void DuplicateMultipleViews(View selectedView, int numberOfViews)
        {
            // Duplicate the view in Revit multiple times
            for (int i = 1; i <= numberOfViews; i++)
            {
                using (Transaction duplicationTransaction = new Transaction(doc, $"Duplicate View {i}"))
                {
                    duplicationTransaction.Start();

                    // Assuming you want to duplicate the view
                    View duplicateView = doc.GetElement(selectedView.Duplicate(ViewDuplicateOption.Duplicate)) as View;

                    // Adjust the name of the duplicated view
                    string viewName = $"{Lb_DuplicateViewPreffixName.Text}{Lb_DuplicateViewName.Text}{Lb_DuplicateViewsSuffixName.Text}{i}";
                    duplicateView.Name = viewName;

                    duplicationTransaction.Commit();
                }
            }
        }


        private View GetViewInModel(string viewName)
        {
            // Implement logic to get the View based on its name
            // For example:
            return new FilteredElementCollector(doc)
                .OfClass(typeof(View))
                .Cast<View>()
                .FirstOrDefault(view => view.Name == viewName);
        }

        #endregion
        

        #region Minimize, Restore, Close and Cancel window buttons

        private void Btn_CancelClick(object sender, RoutedEventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void Btn_RestoreClick(object sender, RoutedEventArgs e)
        {
            // Check if the form is maximized
            if (this.WindowState == WindowState.Maximized)
            {
                // Restore to normal size
                this.WindowState = WindowState.Normal;
            }
            else
            {
                // Maximize the form
                this.WindowState = WindowState.Maximized;
            }
        }

        private void Btn_MinimizeClick(object sender, RoutedEventArgs e)
        {
            // Minimize the form
            this.WindowState = WindowState.Minimized;
        }
        private void Btn_CloseClick(object sender, RoutedEventArgs e)
        {
            // Close the form
            this.Close();
        }


        #endregion

        private void Lb_DuplicateViewPreffixName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
