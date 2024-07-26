using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() 
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double totalTax = 0;

            if (AnualIncome < 20000.00)
            {
                if (HealthExpenditures > 0)
                {
                    totalTax += AnualIncome * 0.15 - HealthExpenditures * 0.5;
                }
                else
                {
                    totalTax = AnualIncome * 0.15;
                }
            }
            else
            {
                if (HealthExpenditures > 0)
                {
                    totalTax += (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                }
                else
                {
                    totalTax = AnualIncome * 0.25;
                }
            }

            return totalTax;
        }
    }
}
