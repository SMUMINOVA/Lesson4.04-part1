using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter firstSum = new Converter();
            System.Console.Write("Enter amount: ");
            double sum = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Choose currency:\n1. USD\t2. EUR\n3. RUB\t4. TJS");
            int choice = int.Parse(Console.ReadLine());
            firstSum.amount = sum;
        
            if (choice != 4){
                switch(choice){
                case 1: firstSum.toTjs(firstSum.usd, firstSum.amount); break;
                case 2: firstSum.toTjs(firstSum.eur, firstSum.amount); break;
                case 3: firstSum.toTjs(firstSum.rub, firstSum.amount); break;
                }
            }
            else {
                System.Console.WriteLine("To which currancy do you want to convert your amount?");
                System.Console.WriteLine("1. USD\n2. EUR\n3. RUB");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                case 1: firstSum.toUsd(firstSum.usd, firstSum.amount); break;
                case 2: firstSum.toEur(firstSum.eur, firstSum.amount); break;
                case 3: firstSum.toRub(firstSum.rub, firstSum.amount); break;
                }
            }
            Console.ReadKey();
        }
        class Converter{
            public double amount {get;set;}
            public double usd {get;set;} 
            public double eur {get;set;}
            public double rub {get;set;}
            public double tjs {get;set;}
            public Converter (double Usd = 10.22, double Eur = 11.04, double Rub = 0.13){
                usd = Usd;
                eur = Eur;
                rub = Rub;
            } 
            public void toTjs(double converter, double sum){
                System.Console.WriteLine($"in TJS: {sum*converter}"); 
            }
            public void toUsd(double converter, double sum){
                System.Console.WriteLine($"in TJS: {sum/converter}"); 
            }
            public void toEur(double converter, double sum){
                System.Console.WriteLine($"in TJS: {sum/converter}"); 
            }
            public void toRub(double converter, double sum){
                System.Console.WriteLine($"in TJS: {sum/converter}"); 
            }
        }
    }
}
