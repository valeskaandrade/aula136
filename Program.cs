using System;
using System.Globalization;
using System.Collections.Generic;
using MetodoAbstrato.Entities;

namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> l = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse (Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("/Individual or company(i / c) ? ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                             

                if (c == 'i')
                {                 
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    l.Add(new Individual (name,anualIncome,healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    l.Add(new Company(name, anualIncome, numberOfEmployees));

                }
               
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            Console.WriteLine();

            double totalTaxes = 0.00;
            foreach (TaxPayer t in l)
            {

                totalTaxes += t.Tax();
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $" );
            Console.WriteLine(totalTaxes.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
