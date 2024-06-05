using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertendoMoeda.Classes
{
    public class Moeda
    {
        public decimal Value { get; private set; }

        public void RealParaDolar(decimal value)
        {
            Value = value / 5.30m;
            Console.WriteLine(Value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }

        public void RealParaEuro(decimal value)
        {
            Value = value / 5.76m;
            Console.WriteLine(Value.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
        }

        public void RealParaIene(decimal value)
        {
            Value = value / 0.034m;
            Console.WriteLine(Value.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
        }

        public void RealParaLibraEsterlina(decimal value)
        {
            Value = value / 6.78m;
            Console.WriteLine(Value.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
        }

        public void SetValue(decimal value)
        {
            Value = value;
        }
    }
}
