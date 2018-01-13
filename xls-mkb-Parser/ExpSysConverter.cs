using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace xls_mkb_Parser
{
    static class ExpSysConverter
    {
        /// <summary>
        /// Structure is describing types(format) of conversion that allows to know a file extension which is accesible for an one.
        /// </summary>
        public struct ConvertTypes
        {
            readonly string fromExt; //extension of file, from which starts conversion
            readonly string toExt;   //conversion is finished to this extension of file 

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
                int numOfLastRow = 0;
                var app = new Application();
                app.Workbooks.Open(filePath);
                var myWorkbook = app.ActiveWorkbook;
                var myWorksheet = (Worksheet)myWorkbook.Sheets[1];

                StreamWriter sw = new StreamWriter(savePath, false, Encoding.GetEncoding("Windows-1251"));

                string str = "";
                int count = 0;
                var lastCell = myWorksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell);

                //записываем название, автора и вопросы
                for (int i = 0; i < lastCell.Column; i++)
                {
                    for (int j = 0; j < lastCell.Row; j++)
                    {
                        str = myWorksheet.Cells[j + 1, i + 1].Text.ToString();
                        if ((myWorksheet.Cells[j + 1, 1].Text.ToString() == "") || (myWorksheet.Cells[j + 1, 1].Text.ToString() == "    "))
                            count++;
                        sw.WriteLine(str, Encoding.GetEncoding("Windows-1251"));
                        if (count == 2)
                        {
                            numOfLastRow = j + 1;
                            break;
                        }
                    }
                    if (count == 2) break;
                }


                //записываем вероятности
                for (int j = numOfLastRow; j < lastCell.Row; j++)
                {
                    for (int i = 0; i < lastCell.Column; i++)
                    {
                        str = myWorksheet.Cells[j + 1, i + 1].Text.ToString();
                        str = str.Replace(",", ".");
                        if ((myWorksheet.Cells[j + 1, i + 2].Text.ToString() == "") ||
                            (myWorksheet.Cells[j + 1, i + 2].Text.ToString() == "    "))
                        {
                            str += "\r\n";
                            sw.Write(str);
                            break;
                        }
                        else
                        {
                            str += ",";
                            sw.Write(str);
                        }
                    }
                }
                sw.Close();
                Process.Start("C:\\Windows\\System32\\notepad.exe", savePath);
                myWorkbook.Close(false);
                app.Quit();
            return true;
        }

        public static Boolean ConvertFromMkbToXlsx(string filePath, string savePath)
        {
                Application app = new Application();
                app.Visible = true;
                //app.Workbooks.Open(filePath, Type.Missing, true);
                app.Workbooks.OpenText(
                    filePath,
                    XlPlatform.xlWindows,
                    1, //С 1 строки 
                    XlTextParsingType.xlDelimited, //Текст с разделителями 
                    XlTextQualifier.xlTextQualifierNone, //Признак окончания разбора строки 
                    true, //Разделители одинарные 
                    true, //Разделители :Tab 
                    false, //Semicolon 
                    true, //Comma 
                    false, //Space 
                    false, //Other 
                    Type.Missing, //OtherChar 
                    Type.Missing,
                    Type.Missing,  //Размещение текста 
                    ".",           //Разделитель десятичных разрядов 
                    Type.Missing);           //Разделитель тысяч 
                                /* sheets = wBook.Worksheets;
                                 sheet = (Worksheet) sheets.Item[1];*/
                    var sheet = (Worksheet)app.Sheets.Item[1];
                int counter = 2;
                int i = 1;
                while (counter != 0)
                {
                    int j = 1;
                    string str = Convert.ToString(sheet.Cells[i, 1].Value2);
                    if (string.IsNullOrEmpty(str)) counter --;
                    else
                    {
                        while (true)
                        {
                            j++;
                            str = Convert.ToString(sheet.Cells[i, j].Value2);
                            if (!string.IsNullOrEmpty(str))
                            {
                                sheet.Cells[i, 1].Value2 += str;
                                sheet.Cells[i, j].Value2 = "";
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    i++;
                }
                app.Workbooks.Item[1]._SaveAs(savePath,
                    XlFileFormat.xlWorkbookDefault,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    XlSaveAsAccessMode.xlNoChange,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    true
                    );
            app = null;
            return true;
        }
    }
}
