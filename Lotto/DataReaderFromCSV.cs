using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Lotto
{
    class DataReaderFromCSV : DataReader
    {
        const string fileName = "lotto.csv";
        readonly char[] trimCharacters = { ',' };
        ////const string datePattern = @"^(\d{1,2})\/(\d{1,2})\/(\d{4})";
        //const string datePattern = @"^(\d{1,2})\.(\d{1,2})\.(\d{4})";

        public List<Extraction> GetExtractions()
        {
            List<Extraction> result = new List<Extraction>();
            //DateTime dt = new DateTime();

            string line;
            StreamReader file = new StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                Extraction extraction = new Extraction();
                string[] cells = line.Split(trimCharacters);
                foreach (string cellInfo in cells)
                {
                    //if (Regex.IsMatch(cellInfo, datePattern))
                    //{
                    //    DateTime.TryParse(cellInfo, out dt);
                    //    extraction.ExtractionDate = dt;// Convert.ToDateTime(cellInfo);
                    //}
                    //else
                        extraction.Numbers.Add(Convert.ToByte(cellInfo));
                }
                result.Add(extraction);
            }


            return result;
        }
    }
}
