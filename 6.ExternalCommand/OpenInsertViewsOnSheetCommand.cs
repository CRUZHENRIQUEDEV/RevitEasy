using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitEasy.InsertViewsOnSheetsWPF;
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenInsertViewsOnSheetsFormCommand : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            try
            {
                // Obtém o documento ativo
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Document doc = uidoc.Document;

                // Cria uma instância do formulário WPF InsertViewsOnSheetsFormWPF
                InsertViewsOnSheetsFormWPF insertViewsForm = new InsertViewsOnSheetsFormWPF(doc);

                // Exibe o formulário WPF
                insertViewsForm.ShowDialog();

                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
        }
    }
}
