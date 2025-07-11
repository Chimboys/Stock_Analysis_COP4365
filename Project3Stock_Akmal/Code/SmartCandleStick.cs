﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Project3Stock_Akmal.Code
{
    //SmartCandleStick is a child class of CandleStick that inherits all of its fields 
    public class SmartCandleStick : CandleStick
    {
        /// <summary>
        /// Creating constructor that accepts data to call parent class contrustor as well as fills in dictionary with values
        /// Values are boolean that represent if candlestick meets the patterns 
        /// </summary>
        /// <param name="data"></param>
        /// 

        public SmartCandleStick(string[] data) : base(data)
        {
            ComputeOneStickProperty();
        }



        //Defining properties and getters for SmartCandleStick properties 
        public decimal BodyRange
        {
            get
            {
                return Math.Abs(Open - Close);
            }
        }

        public decimal Range
        {
            get
            {
                return Math.Abs(High - Low);
            }
        }


        public decimal BottomPrice
        {
            get
            {
                return Math.Min(Open, Close);
            }
        }

        public decimal TopPrice
        {
            get
            {
                return Math.Max(Open, Close);
            }
        }

        public decimal UpperTail
        {
            get
            {
                return High - TopPrice;
            }
        }

        public decimal LowerTail
        {
            get
            {
                return BottomPrice - Low;
            }
        }

        public Dictionary<string, bool> Patterns { get; private set; } = new Dictionary<string, bool>();
        private void ComputeOneStickProperty()
        {
            //Checking if Bullish 
            bool isBullish = Close > Open;
            Patterns.Add("Bullish", isBullish);

            //Checking if Bearish 
            bool isBearish = Open > Close;
            Patterns.Add("Bearish", isBearish);

            //Checking if Neutral 
            bool isNeutral = BodyRange < (Range * 0.2m);
            Patterns.Add("Neutral", isNeutral);

            //Checking if Marubozu
            bool isMarubozu = (TopPrice >= High) & (BottomPrice <= Low);
            Patterns.Add("Marubozu", isMarubozu);

            //Checking if Hammer
            bool isHammer = (BodyRange < Range * 0.25m) & (LowerTail > Range * 0.66m);
            Patterns.Add("Hammer", isHammer);

            //Checking if Doji
            bool isDoji = BodyRange <= (Range * 0.01m);
            Patterns.Add("Doji", isDoji);

            //Checking if Dragonfly Doji
            bool dragonfly_doji = isDoji & (LowerTail > Range * 0.66m);
            Patterns.Add("Dragonfly_Doji", dragonfly_doji);

            //Checking if Gravestone doji
            bool gravestone_doji = isDoji & (UpperTail > Range * 0.66m);
            Patterns.Add("Gravestone_Doji", gravestone_doji);
        }

    }


}


