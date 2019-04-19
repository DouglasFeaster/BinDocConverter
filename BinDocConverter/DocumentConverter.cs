using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI;
using NPOI.XWPF.UserModel;

namespace BinDocConverter
{
    public class DocumentConverter
    {
        /// <summary>
        /// Converts Word Document to Plain Text and Writes to Screen
        /// </summary>
        /// <param name="input">Input File Path</param>
        public static void Word(string input)
        {

            string documentPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), input));

            XWPFDocument document = null;

            try
            {
                using (FileStream file = new FileStream(documentPath, FileMode.Open, FileAccess.Read))
                {
                    document = new XWPFDocument(file);

                    Console.WriteLine("Paragraphs: ");

                    foreach (var item in document.Paragraphs)
                    {
                        Console.WriteLine(item.Text);  
                    }

                    Console.WriteLine("Tables: ");

                    foreach (var item in document.Tables)
                    {
                        foreach (var item2 in item.Rows)
                        {
                            foreach (var item3 in item2.GetTableCells())
                            {
                                Console.WriteLine("--------------------");
                                Console.WriteLine(item3.GetText());
                                Console.WriteLine("--------------------"); 
                            }
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        
    }
}
