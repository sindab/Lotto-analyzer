using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Lotto
{
    class DataAnalyser
    {
        public DataAnalyser(List<Extraction> extractions)
        {
            Extractions = extractions;
        }

        public List<Extraction> Extractions { get; set; }

        //public void GetProcentage()
        //{
        //    int[] numbersCount = new int[50];

        //    string[] displayResult = new string[52];

        //    foreach (Extraction extraction in Extractions)
        //    {
        //        foreach (byte b in extraction.NumbersAsArray)
        //        {
        //            numbersCount[b]++;
        //        }
        //    }

        //    foreach (byte b in Enumerable.Range(1, 49))
        //    {
        //        displayResult[b] = ((numbersCount[b] * 1.0) / Extractions.Count * 100).ToString();
        //    }


        //    displayResult[50] = Array.IndexOf(numbersCount, numbersCount.Min(x => x != 0)).ToString();
        //    displayResult[51] = Array.IndexOf(numbersCount, numbersCount.Max()).ToString();

        //    foreach (var b in Enumerable.Range(1, 51))
        //    {
        //        Console.WriteLine("{0} ---> {1}", b, displayResult[b]);
        //    }
        //}

        //public string[] GetResults()
        //{
        //    int[] numbersCount = new int[40];

        //    string[] displayResult = new string[40];

        //    foreach (Extraction extraction in Extractions)
        //    {
        //        foreach (byte b in extraction.NumbersAsArray)
        //        {
        //            numbersCount[b]++;
        //        }
        //    }

        //    foreach (byte b in Enumerable.Range(1, 39))
        //    {
        //        displayResult[b] = b.ToString() + " --> " + ((numbersCount[b] * 1.0) / Extractions.Count * 100).ToString();
        //    }


        //    //displayResult[50] = Array.IndexOf(numbersCount, numbersCount.Min(x => x != 0)).ToString();
        //    //displayResult[51] = Array.IndexOf(numbersCount, numbersCount.Max()).ToString();

        //    //foreach (var b in Enumerable.Range(1, 51))
        //    //{
        //    //    Console.WriteLine("{0} ---> {1}", b, displayResult[b]);
        //    //}

        //    return displayResult;
        //}

        public DataTable GetTableResults()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //DataColumn dc = new DataColumn("I", Type.GetType("int"));
            dt.Columns.Add(new DataColumn("RBr", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("I", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("II", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("III", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("IV", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("V", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("VI", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("VII", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Par", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Nepar", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Suma", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("DI", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("DII", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("DIII", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("DIV", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("DV", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("DVI", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("DVII", Type.GetType("System.Int32")));
            DataRow _red;
            
            //int[] numbersCount = new int[40];
            int nepar;
            int suma;
            int rbr=0;
            
            //string[] displayResult = new string[40];

            foreach (Extraction extraction in Extractions)
            {
                rbr += 1;
                _red = dt.NewRow();
                _red["RBr"] = rbr;
                //_red["RBr"] = extraction.NumbersAsArray[0];
                _red["I"] = extraction.NumbersAsArray[0];
                _red["II"] = extraction.NumbersAsArray[1];
                _red["III"] = extraction.NumbersAsArray[2];
                _red["IV"] = extraction.NumbersAsArray[3];
                _red["V"] = extraction.NumbersAsArray[4];
                _red["VI"] = extraction.NumbersAsArray[5];
                _red["VII"] = extraction.NumbersAsArray[6];
                nepar = Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[0], 2)) + Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[1], 2)) + Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[2], 2)) + Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[3], 2)) + Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[4], 2)) + Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[5], 2)) + Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[6], 2));
                _red["Nepar"] = nepar;
                _red["Par"] = 7 - nepar;
                suma = extraction.NumbersAsArray[0] + extraction.NumbersAsArray[1] + extraction.NumbersAsArray[2] + extraction.NumbersAsArray[3] + extraction.NumbersAsArray[4] + extraction.NumbersAsArray[5] + extraction.NumbersAsArray[6];
                _red["Suma"] = suma;

                _red["DI"] = extraction.NumbersAsArray[0] - extraction.NumbersAsArray[0] % 10;
                _red["DII"] = extraction.NumbersAsArray[1] - extraction.NumbersAsArray[1] % 10;
                _red["DIII"] = extraction.NumbersAsArray[2] - extraction.NumbersAsArray[2] % 10;
                _red["DIV"] = extraction.NumbersAsArray[3] - extraction.NumbersAsArray[3] % 10;
                _red["DV"] = extraction.NumbersAsArray[4] - extraction.NumbersAsArray[4] % 10;
                _red["DVI"] = extraction.NumbersAsArray[5] - extraction.NumbersAsArray[5] % 10;
                _red["DVII"] = extraction.NumbersAsArray[6] - extraction.NumbersAsArray[6] % 10;
                //    //Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[1], 2)) + 
                //    //Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[2], 2)) + 
                //    //Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[3], 2)) + 
                //    //Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[4], 2)) + 
                //    //Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[5], 2)) + 
                //    //Math.Abs((int)Math.IEEERemainder(extraction.NumbersAsArray[6], 2));

                //foreach (byte b in extraction.NumbersAsArray)
                //{
                //    numbersCount[b]++;

                //}
                dt.Rows.Add(_red);
            }

            //foreach (byte b in Enumerable.Range(1, 39))
            //{
            //    displayResult[b] = ((numbersCount[b] * 1.0) / Extractions.Count * 100).ToString();
            //}


            //displayResult[50] = Array.IndexOf(numbersCount, numbersCount.Min(x => x != 0)).ToString();
            //displayResult[51] = Array.IndexOf(numbersCount, numbersCount.Max()).ToString();

            //foreach (var b in Enumerable.Range(1, 51))
            //{
            //    Console.WriteLine("{0} ---> {1}", b, displayResult[b]);
            //}

            return dt;
        }

    }
}
