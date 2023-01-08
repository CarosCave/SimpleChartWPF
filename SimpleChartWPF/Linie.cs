using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SimpleChartWPF
{
    internal class Linie : DiagrammObjekt
    {
        public Linie(Punkt[] punkte) 
        {
            this.punkte.AddRange(punkte);
        }

        public override void Zeichne(Canvas canvas)
        {
            Polyline polyline = new Polyline();

            polyline.StrokeThickness = 2.0;
            polyline.Stroke = Brushes.Green;

            for(int i = 0;i < punkte.Count; i++)
            {
                double x = (punkte[i].Jahr - 1980.0) / (2014 - 1980) * canvas.ActualWidth;
                double y = (1.0 - punkte[i].Wert / 300.0) * canvas.ActualHeight;

                polyline.Points.Add(new System.Windows.Point(x, y));
            }

            canvas.Children.Add(polyline);
        }
    }
}
