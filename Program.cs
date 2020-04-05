using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class Currency{
            public double inUsd {get;set;} 
            public double inEur {get;set;}
            public double inRub {get;set;}
            public double inTjs {get;set;}
            
        }
        class Converter{
            public double usd {get;set;} 
            public double eur {get;set;}
            public double rub {get;set;}
            public double tjs {get;set;}
            //public Converter (double Usd = 10.22, double Eur = 11.04, double Rub = 0.13){
            //    inUsd = Usd;
            //    inEur = Eur;
            //    inRub = Rub;
            //} 
        }
    }
}
