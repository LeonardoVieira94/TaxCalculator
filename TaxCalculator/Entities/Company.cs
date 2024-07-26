using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() 
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double totalTax = 0;

            if (NumberOfEmployees > 10)
            {
                totalTax += AnualIncome * 0.14;
            }
            else
            {
                totalTax += AnualIncome * 0.16;
            }
            return totalTax;

        }
    }
}
