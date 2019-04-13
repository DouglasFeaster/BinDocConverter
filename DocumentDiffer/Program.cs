using System;
using DocumentDiffer.Models;

namespace DocumentDiffer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (HelpFlag.IsHelp(args[0]))
            {
                HelpDocumentationModel helpDocumentation = HelpFlag.GetHelp();

                Console.Write("Usage: ");

                Console.WriteLine(helpDocumentation.Usage);

                Console.WriteLine("Examples:");

                foreach (var item in helpDocumentation.Examples)
                {
                    Console.WriteLine($"    {item}");
                }
            }
            Console.ReadLine();
        }
    }
}
