using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevista_Tecnica_Mercap
{
    public class LocalCall:Call
    {
        public DateTime Date { get; set; }       

        public LocalCall(DateTime date, int durationMinutes)
            :base(durationMinutes)
        {
            Date = date;
        }

        public override double CalculateCost()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                return DurationMinutes * 0.10;
            }
            else if (Date.Hour >= 8 && Date.Hour < 20)
            {
                return DurationMinutes * 0.20;
            }
            else
            {
                return DurationMinutes * 0.10;
            }
        }
    }
}
