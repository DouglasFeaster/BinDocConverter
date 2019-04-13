using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DocumentDiffer
{
    /// <summary>
    /// Help Flag Class
    /// </summary>
    public static class HelpFlag
    {
#if DEBUG
        private static string _helpFile { get; set; } = "";
#else
        private static string _helpFile { get; set; } = @"";
#endif

        /// <summary>
        /// Evaluates Input Argument to see if Input Argument is Help Command
        /// </summary>
        /// <param name="inputArg">Command Line Input Argument</param>
        /// <returns>True or False</returns>
        public static bool IsHelp(string inputArg)
        {
            if (inputArg.ToUpper() == "-HELP" || inputArg.ToUpper() == "-H")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get Help Class for writing help from HelpDocs JSON
        /// </summary>
        public static void GetHelp()
        {
            try
            {
                JsonConvert.DeserializeObject("");
            }
            catch
            {
                Console.WriteLine("Error Occurred when accessing " + _helpFile);
            }
        }
    }
}
