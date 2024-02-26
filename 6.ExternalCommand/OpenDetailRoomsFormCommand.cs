using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitEasy._5.WPF; // Importe o namespace correto para a classe DetailRoomsFormWPF
using System;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenDetailRoomsFormCommand : IExternalCommand
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

                // Cria uma instância do formulário WPF DetailRoomsFormWPF
                DetailRoomsFormWPF detailRoomsForm = new DetailRoomsFormWPF(doc);

                // Exibe o formulário WPF
                detailRoomsForm.ShowDialog();

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
