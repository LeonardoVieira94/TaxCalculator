using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TaxCalculator.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer() 
        {
        }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
