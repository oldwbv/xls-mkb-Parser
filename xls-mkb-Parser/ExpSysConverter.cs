using System;
using System.Linq;
using Microsoft.Office.Interop.Excel;

namespace xls_mkb_Parser
{
    static class ExpSysConverter
    {
        /// <summary>
        /// Structure is describing types(format) of conversion that allows to know a file extension which is accesible for an one.
        /// </summary>
        public struct ConvertTypes
        {
            string fromExt; //extension of file, from which starts conversion
            string toExt;   //conversion is finished to this extension of file 

            //constructor
            public ConvertTypes(string from, string to)
            {
                fromExt = from;
                toExt = to;
            }
            //function to get an extension of source file
            public string GetFromExt()
            {
                return fromExt;
            }
            //function to get an extension of aim file
            public string GetToExt()
            {
                return toExt;
            }
        }

        public static ConvertTypes[] Types = {new ConvertTypes(".mkb", ".xlsx"),
                                              new ConvertTypes(".xlsx", ".mkb")};

        public static Boolean CheckConversionPossibility(string fromExt, string toExt)
        {
            return Types.Any(conType => conType.GetFromExt() == fromExt && conType.GetToExt() == toExt);
        }

        public static Boolean ConvertFromXlsxToMkb(string filePath, string savePath)
        {

            Application app;
            Workbooks wBooks;
            Workbook wBook;
            Sheets sheets;
            Worksheet sheet;
            try
            {
                app = new Application();
                app.Visible = true;
                app.Workbooks.Open(filePath, Type.Missing, true);
               /* sheets = wBook.Worksheets;
                sheet = (Worksheet) sheets.Item[1];*/
            }
            catch (Exception ex)
            {
                
            }
            return true;
        }
    }
}
