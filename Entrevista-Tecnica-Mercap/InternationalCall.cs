using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevista_Tecnica_Mercap
{
    public class InternationalCall : Call
    {
        public string Country { get; set; }
        public DateTime DateTime { get; set; }
        // Diccionario para almacenar las tarifas por país
        private static Dictionary<string, double> countryRates = new Dictionary<string, double>
        {
            {"United States", 0.50 },
            {"Spain", 0.75 },
            {"Argentina",0.25 },
            {"Brasil",0.22 },
            {"Uruguay",0.12 }
            // Agregar más países y tarifas según sea necesario
        };

        public InternationalCall(string country, double durationMinutes, DateTime dateTime)
            :base(durationMinutes)
        {
            Country = country;      
            DateTime = dateTime;
        }

        public override double CalculateCost()
        {
            double costPerMinute;

            // Verificar si existe una tarifa definida para el país
            if (countryRates.ContainsKey(Country))
            {
                // Obtener la tarifa del país desde el diccionario
                costPerMinute = countryRates[Country];
            }
            else
            {
                // Por defecto, se aplica una tarifa genérica de $1.00 por minuto para países no definidos
                costPerMinute = 1.00;
            }

            return DurationMinutes * costPerMinute;
        }
    }
}
