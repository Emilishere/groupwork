using System;

namespace Emek_Haqqi_Komekcisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary:");
            int GrossWage = Convert.ToInt32(Console.ReadLine()); //emek haqqi
            Console.WriteLine("Your marital status; m-married, s-single, w-widow/widower:"); //m-evli; s-subay; w-dul
            string MaritalStatus = Console.ReadLine(); //aile veziyyeti
            int ChildrenNumber = 0; //usaq sayi
            double TotalGrossWage = 0; //umumi gross gelir
            double tax = 0;//vergi
            string Disability = ""; //fiziki qusur
            int ChildMoney = 0; //usaq pulu
            int FamilyAllowance = 0; //aile muavinet
            double RateofTax = 0; //vergi derecesi
            if (MaritalStatus == "w")
            {
                Console.WriteLine("Do you have child/children? y-yes n-no");
                string k = Console.ReadLine();
                if (k == "y")
                {
                    Console.WriteLine("Enter number of your children:");
                    ChildrenNumber = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Do you have any disability? y-yes n-no");
                Disability = Console.ReadLine();
            }
            else if (MaritalStatus == "m")
            {
                Console.WriteLine("Do you have child/children? y-yes n-no");
                string k = Console.ReadLine();
                if (k == "y")
                {
                    Console.WriteLine("Enter number of your children:");
                    ChildrenNumber = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Do you have any disability? y-yes n-no");
                Disability = Console.ReadLine();
            }
            else if (MaritalStatus == "s")
            {
                Console.WriteLine("Do you have any disability? y-yes n-no");
                Disability = Console.ReadLine();
            }
            TotalGrossWage = GrossWage;
            if (MaritalStatus == "m")
            {
                FamilyAllowance = 50;
                TotalGrossWage = TotalGrossWage + FamilyAllowance;
            }
            else
            {
                FamilyAllowance = 0;
                TotalGrossWage = TotalGrossWage + FamilyAllowance;
            }
            if(ChildrenNumber == 1)
            {
                ChildMoney = 30;
                TotalGrossWage = TotalGrossWage + ChildMoney;
            }
            else if (ChildrenNumber == 2)
            {
                ChildMoney = 55;
                TotalGrossWage = TotalGrossWage + ChildMoney;
            }
            else if (ChildrenNumber == 3)
            {
                ChildMoney = 75;
                TotalGrossWage = TotalGrossWage + ChildMoney;
            }
            else if (ChildrenNumber >= 4)
            {
                ChildMoney = 75 + 15 * (ChildrenNumber - 3);
                TotalGrossWage = TotalGrossWage + ChildMoney;
            }
            if (GrossWage <= 1000)
            {
                RateofTax = 15.00 / 100.00;
                tax = TotalGrossWage * RateofTax;
            }
            else if (GrossWage < 2000 && GrossWage > 1000)
            {
                RateofTax = 20.00 / 100.00;
                tax = TotalGrossWage * RateofTax;
            }
            else if (GrossWage >= 2000 && GrossWage < 3000)
            {
                RateofTax = 25.00 / 100.00;
                tax = TotalGrossWage * RateofTax;
            }
            else if (GrossWage >= 3000)
            {
                RateofTax = 30.00 / 100.00;
                tax = TotalGrossWage * RateofTax;
            }
            if (Disability == "y")
            {
                tax = tax * 50 / 100;
            }
            TotalGrossWage = TotalGrossWage - tax;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"FamilyAllowance-{FamilyAllowance.ToString("0.00")}$");
            Console.WriteLine($"Money for kids-{ChildMoney.ToString("0.00")}$");
            Console.WriteLine($"Rate of tax-{RateofTax.ToString("0.00")}%");
            Console.WriteLine($"amount of tax-{tax.ToString("0.00")}$");
            Console.WriteLine($"Entered Salary-{GrossWage.ToString("0.00")}$");
            Console.WriteLine($"Total Gross Wage-{TotalGrossWage.ToString("0.00")}$");
            int twohundred = (int)Math.Floor(TotalGrossWage / 200);
            int onehundred = (int)Math.Floor((TotalGrossWage - twohundred * 200) / 100);
            int fifties = (int)Math.Floor(((TotalGrossWage - twohundred * 200) - onehundred * 100) / 50);
            int twenties = (int)Math.Floor((((TotalGrossWage - twohundred * 200) - onehundred * 100) - fifties * 50) / 20);
            int tens = (int)Math.Floor(((((TotalGrossWage - twohundred * 200) - onehundred * 100) - fifties * 50) - twenties * 20) / 10);
            int fives = (int)Math.Floor((((((TotalGrossWage - twohundred * 200) - onehundred * 100) - fifties * 50) - twenties * 20) - tens * 10) / 5);
            int ones = (int)Math.Floor(((((((TotalGrossWage - twohundred * 200) - onehundred * 100) - fifties * 50) - twenties * 20) - tens * 10) - fives * 5) / 1);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(twohundred + "x 200");
            Console.WriteLine(onehundred + "x 100");
            Console.WriteLine(fifties + "x 50");
            Console.WriteLine(twenties + "x 20");
            Console.WriteLine(tens + "x 10");
            Console.WriteLine(fives + "x 5");
            Console.WriteLine(ones + "x 1");

        }
        
    }
}
