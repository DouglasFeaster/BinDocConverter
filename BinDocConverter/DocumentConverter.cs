using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI;
using NPOI.XWPF.UserModel;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using System.Linq;

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

        /// <summary>
        /// Converts a Power Point Presentation to Plain Text and Writes to Screen
        /// </summary>
        /// <param name="input">Input File Path</param>
        public static void PowerPoint(string input)
        {
            string documentPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), input));
            int numberOfSlides = CountSlides(documentPath);
            Console.WriteLine("Number of slides = {0}", numberOfSlides);
            string slideText;
            for (int i = 0; i < numberOfSlides; i++)
            {
                GetSlideIdAndText(out slideText, documentPath, i);
                Console.WriteLine("Slide #{0} contains: {1}", i + 1, slideText);
            }
        }

        private static int CountSlides(string presentationFile)
        {
            // Open the presentation as read-only.
            using (PresentationDocument presentationDocument = PresentationDocument.Open(presentationFile, false))
            {
                // Pass the presentation to the next CountSlides method
                // and return the slide count.
                return CountSlides(presentationDocument);
            }
        }

        // Count the slides in the presentation.
        private static int CountSlides(PresentationDocument presentationDocument)
        {
            // Check for a null document object.
            if (presentationDocument == null)
            {
                throw new ArgumentNullException("presentationDocument");
            }

            int slidesCount = 0;

            // Get the presentation part of document.
            PresentationPart presentationPart = presentationDocument.PresentationPart;
            // Get the slide count from the SlideParts.
            if (presentationPart != null)
            {
                slidesCount = presentationPart.SlideParts.Count();
            }
            // Return the slide count to the previous method.
            return slidesCount;
        }

        private static void GetSlideIdAndText(out string sldText, string docName, int index)
        {
            using (PresentationDocument ppt = PresentationDocument.Open(docName, false))
            {
                // Get the relationship ID of the first slide.
                PresentationPart part = ppt.PresentationPart;
                OpenXmlElementList slideIds = part.Presentation.SlideIdList.ChildElements;

                string relId = (slideIds[index] as SlideId).RelationshipId;

                // Get the slide part from the relationship ID.
                SlidePart slide = (SlidePart)part.GetPartById(relId);

                // Build a StringBuilder object.
                StringBuilder paragraphText = new StringBuilder();

                // Get the inner text of the slide:
                IEnumerable<A.Text> texts = slide.Slide.Descendants<A.Text>();
                foreach (A.Text text in texts)
                {
                    paragraphText.Append(text.Text);
                }
                sldText = paragraphText.ToString();
            }
        }

    }
}
