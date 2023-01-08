using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChartWPF
{
    internal class Punkt
    {
        int jahr;
        double wert;

        public int Jahr => jahr;
        public double Wert => wert;

        public Punkt(int jahr, double wert)
        {
            this.jahr = jahr;
            this.wert = wert;
        }
    }
}
