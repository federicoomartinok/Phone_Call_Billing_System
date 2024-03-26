using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevista_Tecnica_Mercap
{
    public abstract class Call
    {
        public double DuracionMinutes { get; set; }

        protected Call(double duracionMinutes)
        {
            DuracionMinutes = duracionMinutes;
        }

        public abstract double CalculateCost();
    }
}
