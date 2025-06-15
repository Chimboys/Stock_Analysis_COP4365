using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3Stock_Akmal.Code
{
    /// <summar>
    /// created abstaract class that serves as template for the Recognizer classes 
    /// all classes that inherit from the abstract will be required to have 
    /// constructor with pattern name and its length as well 
    /// method to recognize a specific pattern
    /// </summar> 


    abstract class Recognizer
    {
       // represents pattern name and used in dictionary as a key to access value of the pattern or method to recognize it 
        public string patternName;
        //represents length of the pattern that is used for recognize method to determine edge cases
        public int patternLength;

        //constructor that sets up patternName and patternLength
        public Recognizer(string patternName, int patternLength) 
        {
            this.patternName = patternName;
            this.patternLength = patternLength;
        }
        //method to determine if pattern is met by a smartcandlestick
        public abstract bool Recognize(BindingList<SmartCandleStick> smartCandleSticks, int index);
       

    }


}
