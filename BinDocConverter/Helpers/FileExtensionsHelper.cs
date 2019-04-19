using BinDocConverter.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BinDocConverter.Helpers
{
    public class FileExtensionsHelper
    {
#if DEBUG
        private static string _fileExtensionsFile { get; set; } = @".\FileExtensions.json";
#else
        private static string _fileExtensionsFile { get; set; } = @".\FileExtensions.json";
#endif

        /// <summary>
        /// Evaluates Input File Path to see if target is MS Word Document 
        /// </summary>
        /// <param name="input">Input File Path</param>
        /// <returns>True or False</returns>
        public static bool IsWord(string input)
        {
            string extension = String.Empty;

            try
            {
                FileExtensionsModel model = JsonConvert.DeserializeObject<FileExtensionsModel>(File.ReadAllText(_fileExtensionsFile));

                foreach (var item in model.Applications.Word)
                {
                    extension = item;

                    if (input.ToUpper().Contains(item.ToUpper()))
                    {
                        break;
                    }
                }

                if (input.ToUpper().Contains(extension.ToUpper()))
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Evaluates Input File Path to see if target is MS Excel Spreadsheet 
        /// </summary>
        /// <param name="input">Input File Path</param>
        /// <returns>True or False</returns>
        public static bool IsExcel(string input)
        {
            string extension = String.Empty;

            try
            {
                FileExtensionsModel model = JsonConvert.DeserializeObject<FileExtensionsModel>(File.ReadAllText(_fileExtensionsFile));

                foreach (var item in model.Applications.Excel)
                {
                    extension = item;

                    if (input.ToUpper().Contains(item.ToUpper()))
                    {
                        break;
                    }
                }

                if (input.ToUpper().Contains(extension.ToUpper()))
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Evaluates Input File Path to see if target is MS PowerPoint Presentation 
        /// </summary>
        /// <param name="input">Input File Path</param>
        /// <returns>True or False</returns>
        public static bool IsPowerPoint(string input)
        {
            string extension = String.Empty;

            try
            {
                FileExtensionsModel model = JsonConvert.DeserializeObject<FileExtensionsModel>(File.ReadAllText(_fileExtensionsFile));

                foreach (var item in model.Applications.PowerPoint)
                {
                    extension = item;

                    if (input.ToUpper().Contains(item.ToUpper()))
                    {
                        break;
                    }
                }

                if (input.ToUpper().Contains(extension.ToUpper()))
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Evaluates Input File Path to see if target is PDF Document
        /// </summary>
        /// <param name="input">Input File Path</param>
        /// <returns>True or False</returns>
        public static bool IsPDF(string input)
        {
            string extension = String.Empty;

            try
            {
                FileExtensionsModel model = JsonConvert.DeserializeObject<FileExtensionsModel>(File.ReadAllText(_fileExtensionsFile));

                foreach (var item in model.Applications.Adobe)
                {
                    extension = item;

                    if (input.ToUpper().Contains(item.ToUpper()))
                    {
                        break;
                    }
                }

                if (input.ToUpper().Contains(extension.ToUpper()))
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
