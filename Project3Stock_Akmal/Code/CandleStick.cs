using System;


namespace Project3Stock_Akmal.Code
{
    /// <summary>
    /// Defining a class to represent candlestick.
    /// </summary>
    public class CandleStick
    {
        public DateTime Date { get; set; } // Representing data and time for canlestick
        public decimal Open { get; set; } // Representing open price for canlestick
        public decimal Close { get; set; } // Representing close price for canlestick
        public decimal High { get; set; } // Representing the highest price candlestick reached
        public decimal Low { get; set; } // Representing the lowest price candlestick reached
        public long Volume { get; set; } // Representing volume of candlestick 

        /// <summary>
        /// Creates a new instance of the CandleStick class and initializes it with data
        /// </summary>
        public CandleStick(string[] data)
        {
            // Checking that input array has 7 values otherwise file is invalid
            if (data.Length == 7)
            {
                Date = DateTime.Parse(data[0]); //Parsing 1st element of data and assigning it to Date
                Open = decimal.Parse(data[1]); //Parsing 2nd element of data and assigning it to Open
                High = decimal.Parse(data[2]); // Parsing 3rd element of data and assigning it to High
                Low = decimal.Parse(data[3]); ///Parsing 4th element of data and assigning it to Low
                Close = decimal.Parse(data[4]); // /Parsing 5th element of data and assigning it to Close
                Volume = long.Parse(data[6]); // /Parsing 7th element of data and assigning it to Volume
                //data[5] was skipped because it contains adjusted volume
            }
            // Throw an exception if there're not enough values
            else
            {
                throw new Exception("Input values array should have at least 7 elements.");
            }
        }
    }
}
