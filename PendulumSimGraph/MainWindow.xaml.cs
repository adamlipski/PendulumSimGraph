using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace PendulumSimGraph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double x_p = 20;
        double y_p = 40;
        double[] points = { 10, 20 };




        ObservableCollection<string> point = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            var stringTemp = points[0].ToString();
            point.Add(stringTemp);
            point.Add(points[1].ToString());
            rysownik.DataContext = point;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //PendulumSim pendulum = new PendulumSim(
            //    Convert.ToDouble(txtbOmega.Text),
            //    Convert.ToDouble(txtbTeta.Text),
            //    Convert.ToDouble(txtbdt.Text),
            //    Convert.ToDouble(txtbRadius.Text));

            double omega, teta, t, dt, x, y, r, g;


            r = 40;       //[m]
            g = 9.8f;    //[m/s^2]
            dt = 0.01f;

            omega = 0.0f;
            int tetaDeg = 45; // degrees

            //teta = 4.0f;


            //Converting degrees to radians

            //teta2 = (float)((Math.PI / 180) * (float)tetaDeg);
            teta = Math.PI / 180 * tetaDeg;

            //Console.WriteLine($"Converstion from {tetaDeg} degrees to {teta2} radians");
            //Console.WriteLine("Sin of 30 deg:" + Math.Sin(teta2));

            for (t = 0; t < 10; t += dt)
            {
             

                omega = (float)(omega + (g / r) * Math.Sin(teta) * dt);

                teta = teta - omega * dt;



                double angle = (teta * 180) / Math.PI;

                x = (float)(r * Math.Sin(teta));
                y = (float)(r * Math.Cos(teta));
                Thread.Sleep(1);
                wahadlo.X1 = x;
                Thread.Sleep(1);
                wahadlo.Y1 = y;
                Thread.Sleep(1);



            }    

        }

    }
}
