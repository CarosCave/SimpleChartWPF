using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace SimpleChartWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<DiagrammObjekt> diagramm = new List<DiagrammObjekt>();

            string[] zeilen = File.ReadAllLines(@"..\..\..\daten.txt");
            
            for (int i = 0; i < zeilen.Length; i++)
            {
                string[] teile = zeilen[i].Split(";");
                int anzahlPunkte = (teile.Length - 1) / 2;
                Punkt[] punkte = new Punkt[anzahlPunkte];

                for (int j = 0; j < anzahlPunkte; j++)
                {
                    int jahr = Convert.ToInt32(teile[2 * j + 1]);
                    double wert = Convert.ToDouble(teile[2 * j + 2]);
                    punkte[j] = new Punkt(jahr, wert);
                }

                switch (teile[0])
                {
                    case "Linie":
                        diagramm.Add(new Linie(punkte));
                        break;
                    case "Punkte":
                        diagramm.Add(new Punkte(punkte));
                        break;
                    default:
                        break;
                }
            }

            foreach (var diaObj in diagramm)
            {
                diaObj.Zeichne(Zeichenfläche);
            }
        }
    }
}
