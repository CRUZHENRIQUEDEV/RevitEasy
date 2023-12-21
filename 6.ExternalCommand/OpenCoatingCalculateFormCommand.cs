// Certifique-se de ter o namespace correto aqui
using RevitEasy.CoatingCalculateForm;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenCoatingCalculateFormCommand : IExternalCommand
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
                CoatingCalculateForm.CoatingCalculateForm coatingCalculateForm = new CoatingCalculateForm.CoatingCalculateForm(doc);

                // Exibe o formulário
                coatingCalculateForm.ShowDialog();

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
