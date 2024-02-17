using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitEasy._5.WPF;
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenCreateListSheetsFormCommand : IExternalCommand
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

                // Cria uma instância do formulário WPF CreateListSheetsFormWPF
                CreateListSheetsFormWPF createListSheetsForm = new CreateListSheetsFormWPF(doc);

                // Exibe o formulário WPF
                createListSheetsForm.ShowDialog();

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
