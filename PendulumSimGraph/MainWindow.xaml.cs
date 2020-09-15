using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        double omega, teta, t, dt, x, y, r, g;
        int tetaDeg;

        

     


        ObservableCollection<string> point = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            var stringTemp = points[0].ToString();
            point.Add(stringTemp);
            point.Add(points[1].ToString());
            rysownik.DataContext = point;
            r = 40;       //[m]
            g = 9.8f;    //[m/s^2]
            dt = 0.04f;

            omega = 0.0f;
            tetaDeg = 45;
            teta = Math.PI / 180 * tetaDeg;
            t = 0;
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CompositionTarget.Rendering += StartAnimation;
           
          

        }

        private void StartAnimation(object sender, EventArgs e)
        {
            
            omega = (float)(omega + (g / r) * Math.Sin(teta) * dt);
            teta = teta - omega * dt;

            wahadlo.X2 = (float)(r * Math.Sin(teta));
            wahadlo.Y2 = (float)(r * Math.Cos(teta));
            t += dt;
            txtbdt.Text = t.ToString();

            if (false)
            {
                StartAnimation(sender, e);
            }
            else
            {
                Stopwatch.StartNew();
            }
        }
    }
}
