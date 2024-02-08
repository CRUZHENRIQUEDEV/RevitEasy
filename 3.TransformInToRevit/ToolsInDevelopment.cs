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
            TaskDialog.Show("Automation API", "This tool is still under development and will be implemented in the future,Please wait! :') ");
            return Result.Succeeded;
        }
    }
}
