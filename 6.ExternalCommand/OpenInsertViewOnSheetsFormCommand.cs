using RevitEasy.InsertViewsOnSheetForm.forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenInsertViewOnSheetsFormCommand : IExternalCommand
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

                // Cria uma instância do formulário, passando o documento como argumento
                Form_InsertViewsOnSheets insertViewsForm = new Form_InsertViewsOnSheets(doc);

                // Exibe o formulário
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
