using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SimpleChartWPF
{
    internal class Punkte : DiagrammObjekt
    {        
        public Punkte(Punkt[] punkte)
        {
            this.punkte.AddRange(punkte);
        }
        public override void Zeichne(Canvas canvas)
        {
            //throw new NotImplementedException();
        }
    }
}
