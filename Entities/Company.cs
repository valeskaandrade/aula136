using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoAbstrato.Entities
{
    class Company : TaxPayer // pessoa jurídica
    {
        public int NumberOfEmployees { get; set; } //número de funcionários
    
        public Company(string name, double anualIncome,int numberOfEmployees) : base ( name,  anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax;
            if (NumberOfEmployees > 10)
            {
                tax = AnualIncome * 14.0 / 100;
            }
            else
            {
                tax = AnualIncome * 16.0 / 100;
            }
         
            return tax;
        }
    }
}
