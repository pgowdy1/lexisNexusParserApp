using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using Xceed.Words.NET;

namespace krisParserApp
{
    //class ParserLogic
    //{
    //    public void Initialize()
    //    {
    //        int x = 0;
    //        while (x == 0)
    //        {
    //            Console.WriteLine("Please enter the path of the file you wish to convert (including the extension): ");
    //            string filePath = Console.ReadLine();

    //            if (filePath.ToLower().Equals("exit"))
    //                x = 1;

    //            if (System.IO.File.Exists(filePath))
    //            {
    //                DocX docx = DocX.Load(filePath);

    //                Console.WriteLine("Enter a name for the output file (do not include an extension): ");
    //                string outputFileName = Console.ReadLine();
    //                string outputFilePath = String.Format((@"C:\\Users\\pgowdy\\Documents\\{0}.txt"), outputFileName);
    //                System.IO.StreamWriter file = new System.IO.StreamWriter(outputFilePath);

    //                List<Section> appliceableSections = docx.Sections.GetRange(2, docx.Sections.Count - 2);
    //                foreach (Section section in appliceableSections)
    //                {
    //                    Parser.ParseSections(section, file);
    //                }

    //                file.Close();
    //                Console.WriteLine("Your file has been written to " + outputFileName + ". You may type 'exit' to quit the application.");
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}

    //class Parser
    //{
    //    public static void ParseSections(Section section, StreamWriter outputFile)
    //    {
    //        try
    //        {
    //            //Retrieve Title Information
    //            string articleTitle = section.SectionParagraphs.ElementAt(1).Text;
    //            outputFile.WriteLine(articleTitle.Trim());
    //            //Console.WriteLine(articleTitle);

    //            string articleLocationAndPublication = section.SectionParagraphs.ElementAt(2).Text;

    //            //Retrieve Article Location Information
    //            string location = Regex.Match(articleLocationAndPublication, @"(?<=\().+?(?=\))").Value;
    //            outputFile.WriteLine(location.Trim());
    //            //Console.WriteLine(location);

    //            //Retrieve Publication Information
    //            int publicationEndIndex = articleLocationAndPublication.IndexOf("(");
    //            string publication = articleLocationAndPublication.Substring(0, publicationEndIndex - 1);
    //            outputFile.WriteLine(publication.Trim());
    //            //Console.WriteLine(publication);

    //            //Retrieve Date of Article and then remove Day of Week published
    //            string dateOfArticle = section.SectionParagraphs.ElementAt(3).Text;
    //            string dayOfWeek = RetrieveDayOfTheWeek(dateOfArticle);
    //            dateOfArticle = dateOfArticle.Replace(dayOfWeek, String.Empty);
    //            outputFile.WriteLine(dateOfArticle.Trim());
    //            //Console.WriteLine(dateOfArticle);

    //            outputFile.WriteLine(dayOfWeek);
    //            //Console.WriteLine(dayOfWeek);

    //            //Retrieve Body of Article and Sanitize
    //            //List<Paragraph> bodyOfArticle = section.SectionParagraphs.GetRange(10, section.SectionParagraphs.Count - 11);
    //            //string content = "";
    //            //foreach (Paragraph paragraph in bodyOfArticle)
    //            //{
    //            //    if (paragraph.Text.StartsWith("Classification") || paragraph.Text.StartsWith("Graphic"))
    //            //        break;

    //            //    content += paragraph.Text;
    //            //}

    //            //Remove commas in the body befre we write it to the file. 
    //            content = content.Replace(",", "");
    //            outputFile.WriteLine(content + Environment.NewLine);
    //            //Console.WriteLine(content);

    //            //Console.WriteLine();
    //        }
    //        catch (ArgumentOutOfRangeException e)
    //        {
    //            //Do nothing. Just skip it because it's not what we're looking for.
    //        }
    //    }

    //    private static string RetrieveDayOfTheWeek(string value)
    //    {
    //        if (value.Contains("Monday"))
    //            return "Monday";
    //        else if (value.Contains("Tuesday"))
    //            return "Tuesday";
    //        else if (value.Contains("Wednesday"))
    //            return "Wednesday";
    //        else if (value.Contains("Thursday"))
    //            return "Thursday";
    //        else if (value.Contains("Friday"))
    //            return "Friday";
    //        else if (value.Contains("Saturday"))
    //            return "Saturday";
    //        else if (value.Contains("Sunday"))
    //            return "Sunday";

    //        return "No Date Of Week Info.";
    //    }
    //}
}
