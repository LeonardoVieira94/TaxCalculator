using TaxCalculator.Entities;
using System;
using System.Globalization;
using System.Data;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer# {i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char opt = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (opt == 'i')
                {
                    Console.Write(" Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("TAXES PAID: ");
            double sum = 0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
                sum += taxPayer.Tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum} ");
        }
    }
}