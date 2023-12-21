using RevitEasy.DuplicateSheduleForm.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenCreateSheetFormCommand : IExternalCommand
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

                // Cria uma instância do formulário
                CreateSheetForm createSheetForm = new CreateSheetForm(doc);

                // Exibe o formulário
                createSheetForm.ShowDialog();

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
