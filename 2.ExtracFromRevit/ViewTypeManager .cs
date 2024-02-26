using Autodesk.Revit.DB;
using System.Collections.Generic;
using System.Linq;

namespace RevitEasy.LoadViewTypes
{
    public class ViewTypeManager
    {
        private readonly Document doc;

        public ViewTypeManager(Document document)
        {
            doc = document;
        }

        public IList<string> GetViewTypes()
        {
            IList<ViewFamilyType> viewTypes = new FilteredElementCollector(doc)
                .OfClass(typeof(ViewFamilyType))
                .Cast<ViewFamilyType>()
                .ToList();

            return viewTypes.Select(t => t.Name).ToList();
        }

        [System.Obsolete]
        public IList<string> GetInstanceParametersForViewType(string selectedViewsType)
        {
            if (string.IsNullOrEmpty(selectedViewsType))
            {
                return new List<string>();
            }

            IEnumerable<ViewFamilyType> viewTypes = new FilteredElementCollector(doc)
                .OfClass(typeof(ViewFamilyType))
                .Cast<ViewFamilyType>();

            ViewFamilyType targetViewType = viewTypes.FirstOrDefault(vt => vt.Name == selectedViewsType);

            if (targetViewType != null)
            {
                IEnumerable<Autodesk.Revit.DB.View> views = new FilteredElementCollector(doc)
                    .OfCategory(BuiltInCategory.OST_Views)
                    .OfClass(typeof(Autodesk.Revit.DB.View))
                    .Cast<Autodesk.Revit.DB.View>()
                    .Where(predicate: v => v.GetTypeId().IntegerValue == targetViewType.Id.IntegerValue);

                List<string> instanceParametersList = new List<string>();

                foreach (Autodesk.Revit.DB.View view in views)
                {
                    IEnumerable<Autodesk.Revit.DB.Parameter> instanceParameters = view.Parameters.Cast<Autodesk.Revit.DB.Parameter>();
                    instanceParametersList.AddRange(instanceParameters.Select(parameter => parameter.Definition.Name));
                }

                return instanceParametersList.Distinct().ToList();
            }

            return new List<string>();
        }
    }
}
