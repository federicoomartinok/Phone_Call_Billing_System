using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevista_Tecnica_Mercap
{
    public abstract class Call
    {
        public double DurationMinutes { get; set; }

        protected Call(double durationMinutes)
        {
            DurationMinutes = durationMinutes;
        }

        public abstract double CalculateCost();
    }
}
