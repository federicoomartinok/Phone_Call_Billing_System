using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevista_Tecnica_Mercap
{
    public class LocalCall:Call
    {
        public DateTime DateTime { get; set; }       

        public LocalCall(DateTime dateTime, int durationMinutes):base(durationMinutes)
        {
            DateTime = dateTime;
        }

        public override double CalculateCost()
        {
            if (DateTime.DayOfWeek == DayOfWeek.Saturday || DateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return DuracionMinutes * 0.10;
            }
            else if (DateTime.Hour >= 8 && DateTime.Hour < 20)
            {
                return DuracionMinutes * 0.20;
            }
            else
            {
                return DuracionMinutes * 0.10;
            }
        }
    }
}
