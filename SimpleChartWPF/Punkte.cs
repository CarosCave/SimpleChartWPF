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
    internal class Punkte : DiagrammObjekt
    {        
        public Punkte(Punkt[] punkte)
        {
            this.punkte.AddRange(punkte);
        }
        public override void Zeichne(Canvas canvas)
        {
            for (int i = 0; i < punkte.Count; i++)
            {
                double x = (punkte[i].Jahr - 1980.0) / (2014 - 1980) * canvas.ActualWidth;
                double y = (1.0 - punkte[i].Wert / 300.0) * canvas.ActualHeight;

                Ellipse elli = new Ellipse();
                elli.Fill = Brushes.Red;

                elli.Width = 10.0;
                elli.Height = 10.0;

                canvas.Children.Add(elli);

                Canvas.SetLeft(elli, x - 5.0);
                Canvas.SetTop(elli, y - 5.0);
            }
        }
    }
}
