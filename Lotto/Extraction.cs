using System;
using System.Collections.Generic;

namespace Lotto
{
    public class Extraction
    {
        public Extraction()
        {
            //ExtractionDate = new DateTime();
            Numbers = new List<byte>();
        }

        //public DateTime ExtractionDate { get; internal set; }

        public List<byte> Numbers { get; internal set; }

        public byte[] NumbersAsArray
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
            return string.Format("{0} {1} {2} {3} {4} {5}",  NumbersAsArray[0], NumbersAsArray[1], NumbersAsArray[2], NumbersAsArray[3], NumbersAsArray[4], NumbersAsArray[5]);
        }
    }
}
