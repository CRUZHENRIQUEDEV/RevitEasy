using Autodesk.Revit.DB;
using System.Linq;
using System.Windows.Controls;

namespace RevitEasy.ExtracFromRevit
{
    internal class ExtractFromRevit
    {
        private readonly Document doc;

        public ExtractFromRevit(Document document)
        {
            doc = document;
        }

        #region get viewTemplates
        public View GetViewTemplateByName(string viewTemplateName)
        {
            // Obtém o View Template pelo nome no Document específico
            View viewTemplate = new FilteredElementCollector(doc)
                .OfClass(typeof(View))
                .Cast<View>()
                .FirstOrDefault(v => v.IsTemplate && v.Name == viewTemplateName);

            return viewTemplate;
        }

        #endregion


    }
}
