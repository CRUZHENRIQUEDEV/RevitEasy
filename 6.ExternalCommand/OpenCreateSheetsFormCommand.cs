using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitEasy._5.WPF; // Importe o namespace correto para a classe CreateSheetsFormWPF
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenCreateSheetsFormCommand : IExternalCommand
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

                // Cria uma instância do formulário WPF CreateSheetsFormWPF
                CreateSheetsFormWPF createSheetsForm = new CreateSheetsFormWPF(doc);

                // Exibe o formulário WPF
                createSheetsForm.ShowDialog();

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
