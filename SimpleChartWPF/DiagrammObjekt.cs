using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SimpleChartWPF
{
    abstract class DiagrammObjekt
    {
        protected List<Punkt> punkte = new List<Punkt>();

        public abstract void Zeichne(Canvas canvas);
    }
}
