using System;
using System.Collections.Generic;
using System.Text;
using MetodoAbstrato.Entities;

namespace MetodoAbstrato.Entities
{
    class Individual : TaxPayer //pessoa física
    {
        public double HealthExpenditures { get; set; } //Gastos com Saúde
     

        public Individual(string name, double anualIncome, double healthExpenditures) : base ( name,  anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double tax;
            if (AnualIncome < 20000.0)
            {
                tax = AnualIncome * 15.0 / 100;
            }
            else
            {
                tax= AnualIncome * 25.0 / 100;
            }
            if (HealthExpenditures > 0)
            {
                tax -= HealthExpenditures / 2;
            }
            return tax;

        }

    }
}
