using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using DocumentDiffer.Models;
using System.IO;

namespace DocumentDiffer
{
    /// <summary>
    /// Help Flag Class
    /// </summary>
    public static class HelpFlag
    {
#if DEBUG
        private static string _helpFile { get; set; } = @".\HelpDocumentation.json";
#else
        private static string _helpFile { get; set; } = @".\HelpDocumentation.json";
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
        public static HelpDocumentationModel GetHelp()
        {
            try
            {
                // read file into a string and deserialize JSON to a type
                HelpDocumentationModel model = JsonConvert.DeserializeObject<HelpDocumentationModel>(File.ReadAllText(_helpFile));

                return model;

            }
            catch
            {
                return null;
            }
        }
    }
}
