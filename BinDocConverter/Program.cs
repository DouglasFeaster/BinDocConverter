using System;
using BinDocConverter.Helpers;
using BinDocConverter.Models;

namespace BinDocConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (HelpFlagHelper.IsHelp(args[0]))
                {
                    HelpUI();
                }
                else if (FileExtensionsHelper.IsWord(args[0]))
                {
                    DocumentConverter.Word(args[0]);
                }
                else if (FileExtensionsHelper.IsExcel(args[0]))
                {
                    Console.WriteLine("Excel");
                }
                else if (FileExtensionsHelper.IsPowerPoint(args[0]))
                {
                    Console.WriteLine("PowerPoint");
                }
                else if (FileExtensionsHelper.IsPDF(args[0]))
                {
                    Console.WriteLine("PDF");
                } 
            }
            else
            {
                HelpUI();
            }

            Console.ReadLine();
        }

        private static void HelpUI()
        {
            HelpDocumentationModel helpDocumentation = HelpFlagHelper.GetHelp();

            Console.Write("Usage: ");

            Console.WriteLine(helpDocumentation.Usage);

            Console.WriteLine("Examples:");

            foreach (var item in helpDocumentation.Examples)
            {
                Console.WriteLine($"    {item}");
            }
        }
    }
}
