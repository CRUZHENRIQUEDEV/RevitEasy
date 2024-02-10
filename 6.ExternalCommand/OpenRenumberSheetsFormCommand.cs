using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitEasy._5.WPF;
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenRenumberSheetsFormCommand : IExternalCommand
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

                // Cria uma instância do formulário WPF RenumberSheetsFormWPF, passando o documento como parâmetro
                RenumberSheetsFormWPF renumberSheetsForm = new RenumberSheetsFormWPF(doc);

                // Exibe o formulário WPF
                renumberSheetsForm.ShowDialog();

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
