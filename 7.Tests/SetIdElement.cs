//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////Name Spaces Add
//using Autodesk.Revit.DB;
//using Autodesk.Revit.ApplicationServices;
//using Autodesk.Revit.UI;
//using Autodesk.Revit.UI.Selection;
//using Autodesk.Revit.Attributes;
//using System.Diagnostics;
//using System.Reflection;
//using Autodesk.Revit.DB.Structure;


//
//namespace setIdElement
//{
//    [Transaction(TransactionMode.Manual)]
//    public class setIdElement : IExternalCommand
//    {
//        public static int cantTotal;
//        public static bool next { get; set; }
//        public static string paramName { get; set; }
//        public Result Execute(ExternalCommandData commandData,
//                              ref string message,
//                              ElementSet elements)

//        {
//            //DECLARACION DE VARIABLES PARA ACCEDER AL DOCUMENTO
//            UIApplication uiApp = commandData.Application;
//            UIDocument uiDoc = uiApp.ActiveUIDocument;
//            Document doc = uiDoc.Document;
//            next = false; //Iniciar el parametro como falso

//            using (frmParameterName frm = new frmParameterName())
//            {
//                frm.ShowDialog();
//            }
//            if (next)
//            {
//                //Todos los elementos fisicos del proyecto
//                List<Element> allElements = Util.AllElement(doc);
//                var list = allElements.Select(item => item.Id).ToList();
//                cantTotal = allElements.Count;
//                int eModificados = 0;
//                using (ExportForm pf = new ExportForm(cantTotal))
//                {
//                    foreach (Element e in allElements)
//                    {
//                        if (e.LookupParameter(paramName) != null)
//                        {
//                            if (e.LookupParameter(paramName).StorageType == StorageType.String)
//                            {
//                                try
//                                {
//                                    using (Transaction t = new Transaction(doc, "param"))
//                                    {
//                                        t.Start();
//                                        e.LookupParameter(paramName).Set(e.Id.ToString());
//                                        ++eModificados;
//                                        t.Commit();
//                                    }
//                                    pf.Increment(cantTotal);
//                                }
//                                catch (Exception err)
//                                {
//                                    TaskDialog.Show("Error Message", err.ToString());
//                                    return Result.Cancelled;
//                                }
//                            }
//                            else
//                            {
//                                TaskDialog.Show("Error Message", "The parameter is not string type \n" +
//                                                                "To be able to execute this add in the parameter must be of String type");
//                                return Result.Cancelled;
//                            }

//                        }
//                        else
//                        {

//                            TaskDialog.Show("Error Message", "There are elements that do not have the selected parameter, " +
//                                                             "Please check if the item has the parameter \n" +
//                                                             " Element ID:" + e.Id.ToString());
//                            return Result.Cancelled;
//                        }
//                    }
//                }

//                TaskDialog.Show("Success", eModificados.ToString() + " were modified of " + allElements.Count.ToString() + " elements");
//            }
//            else
//            {
//                TaskDialog.Show("Error Message", "Set Element ID did not run.");
//            }
//            return Result.Succeeded;
//        }
//    }
//}