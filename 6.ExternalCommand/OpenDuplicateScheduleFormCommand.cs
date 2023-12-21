using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Windows.Forms;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    public class OpenDuplicateScheduleFormCommand : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            try
            {
                // Obtém o documento ativo
                Document doc = commandData.Application.ActiveUIDocument.Document;

                // Cria uma instância do formulário
                DuplicateSheduleForm.Forms.DuplicateScheduleForm form = new DuplicateSheduleForm.Forms.DuplicateScheduleForm(doc);

                // Exibe o formulário como um diálogo
                DialogResult result = form.ShowDialog();

                // Processa o resultado do formulário, se necessário
                if (result == DialogResult.OK)
                {
                    // Lógica a ser executada quando o usuário pressiona "OK"
                    TaskDialog.Show("Informação", "Operação concluída com sucesso!");
                }
                else if (result == DialogResult.Cancel)
                {

                }

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
