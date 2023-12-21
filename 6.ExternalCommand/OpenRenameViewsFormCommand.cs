using RevitEasy.RenameViews.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenRenameViewsFormCommand : IExternalCommand
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
                Wf_RenameViews renameViewsForm = new Wf_RenameViews(doc);

                // Exibe o formulário
                renameViewsForm.ShowDialog();

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
