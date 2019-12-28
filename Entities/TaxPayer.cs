
using System.Globalization;

namespace MetodoAbstrato.Entities
{
    abstract class TaxPayer //Contribuinte
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; } // Renda Anual
        public abstract double Tax(); //imposto pago
      
        public TaxPayer() { }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
