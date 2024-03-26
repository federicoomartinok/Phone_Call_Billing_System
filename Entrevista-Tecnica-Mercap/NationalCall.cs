using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevista_Tecnica_Mercap
{
    public class NationalCall:Call
    {
        public string Locality { get; set; }  

        public NationalCall(string locality, double durationMinutes):base(durationMinutes)
        {
            Locality = locality;
        }
        private static Dictionary<string, double> localtyRates = new Dictionary<string, double>
        {
            {"Corrientes", 0.50 },
            {"Misiones", 0.75 },
            {"Salta",0.25 },
            {"Rio Gallegos",0.22 },
            {"Mendoza",0.12 }
            // Agregar más localidades y tarifas según sea necesario
        };

        public override double CalculateCost()
        {
            double costPerMinute;

            // Verificar si existe una tarifa definida para el país
            if (localtyRates.ContainsKey(Locality))
            {
                // Obtener la tarifa del país desde el diccionario
                costPerMinute = localtyRates[Locality];

            }
            else
            {
                // Por defecto, se aplica una tarifa genérica de $1.00 por minuto para países no definidos
                costPerMinute = 1.00;
            }

            return DuracionMinutes * costPerMinute;
        }
    }
}
