using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project3Stock_Akmal.Code
{
    /// <summary>
    /// Provides methods for reading data from a CSV file.
    /// </summary>
    public static class CSVReader
    {
        /// <summary>
        /// Reads data from a CSV file and returns it in the form of a list of CandleStick objects.
        /// </summary>
        public static List<SmartCandleStick> ReadCSVFile(string filename)
        {
            // create a list for candlesticks
            var candleSticks = new List<SmartCandleStick>(1024);

            // try-catch block for error handling
            try
            {
                // Open the file using stream reader
                using (StreamReader reader = new StreamReader(filename))
                {
                    // Read 1st line to skip table headers
                    reader.ReadLine();

                    // While we haven't reached the end of file
                    while (!reader.EndOfStream)
                    {
                        // Read each row of file
                        string row = reader.ReadLine();

                        // skip null values
                        if (!row.Contains("null"))
                        {
                            // split row string into data array
                            string[] data = row.Split(',');

                            // pass data to candlestick constructor to generate a new instance
                            SmartCandleStick newCandle = new SmartCandleStick(data);
                            // add new candlestick to our list
                            candleSticks.Add(newCandle);
                        }
                    }
                }
            }
            // if an exception occured
            catch
            {
                // return immideately
                return candleSticks;
            }

            return candleSticks;
        }
    }
}
