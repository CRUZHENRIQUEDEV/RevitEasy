using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace RevitEasy
{
    [Transaction(TransactionMode.Manual)]
    class ToolsInDevelopment : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Automação via API", "Esta ferramenta ainda está em desenvolvimento e será implementada no futuro, aguardar!");
            return Result.Succeeded;
        }
    }
}
