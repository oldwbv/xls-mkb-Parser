using System;
using System.Linq;

namespace xls_mkb_Parser
{
    static class ExpSysConverter
    {
        /// <summary>
        /// Structure is describing types(format) of conversion that allows to know a file extension which is accesible for an one.
        /// </summary>
        public struct convertTypes
        {
            string fromExt; //extension of file, from which starts conversion
            string toExt;   //conversion is finished to this extension of file 

            //constructor
            public convertTypes(string from, string to)
            {
                fromExt = from;
                toExt = to;
            }
            //function to get an extension of source file
            public string getFromExt()
            {
                return fromExt;
            }
            //function to get an extension of aim file
            public string getToExt()
            {
                return fromExt;
            }
        }

        public static convertTypes[] Types = {new convertTypes(".mkb", ".xlsx"), new convertTypes(".xlsx", ".mkb")};

       /* public static Boolean CheckSourceFileNameExt(string extension)
        {
            return Types.Any(conType => extension == conType.getFromExt());
        }*/

        public static Boolean CheckConversionPossibility(string fromExt, string toExt)
        {
            return Types.Any(conType => conType.getFromExt() == fromExt && conType.getToExt() == toExt);
        }
    }
}
