using System;
using System.Collections.Generic;

namespace Lotto
{
    public class Extraction
    {
        public Extraction()
        {
            //ExtractionDate = new DateTime();
            Numbers = new List<Int32>();
        }

        //public DateTime ExtractionDate { get; internal set; }

        public List<Int32> Numbers { get; internal set; }

        public Int32[] NumbersAsArray
        {
            get
            {
                var result = Numbers.ToArray();
                Array.Sort(result);
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}",  NumbersAsArray[0], NumbersAsArray[1], NumbersAsArray[2], NumbersAsArray[3], NumbersAsArray[4], NumbersAsArray[5], NumbersAsArray[6], NumbersAsArray[7]);
        }
    }
}
