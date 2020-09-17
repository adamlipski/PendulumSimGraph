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
        bool animationRunning = false;
        bool setValues = false;
        double Vlin;
        double Vx;
        double Vy;
        

     


       
        public MainWindow()
        {
            InitializeComponent();
         

            r = 40;       //[m]
            g = 9.81f;    //[m/s^2]
            dt = 0.02f;

            omega = 0.0f;
            tetaDeg = 45;
            teta = Math.PI / 180 * tetaDeg;
            t = 0;
            
            Canvas.SetLeft(Mass, Canvas.GetLeft(wahadlo) + wahadlo.X2 - Mass.ActualWidth / 2);
            Canvas.SetTop(Mass, wahadlo.Y2 - Mass.ActualHeight / 2);

           
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(setValues == false)
            {
                r = Convert.ToDouble(txtbRadius.Text);
                tetaDeg = Convert.ToInt32(txtbTeta.Text);
                teta = Math.PI / 180 * tetaDeg;

                setValues = true;

            }

            
            

            if(animationRunning==false)
            {
                CompositionTarget.Rendering += StartAnimation;
                animationRunning = true;

            }
            else
            {
                CompositionTarget.Rendering -= StartAnimation;
                animationRunning = false;
            }
           
          

        }
   

        private void StartAnimation(object sender, EventArgs e)
        {
            
            omega = (float)(omega + (g / r) * Math.Sin(teta) * dt);
            teta = teta - omega * dt;

            wahadlo.X2 = (float)(r * Math.Sin(teta));
            
            wahadlo.Y2 = (float)(r * Math.Cos(teta));
            Xp.Text = wahadlo.X2.ToString();
            Yp.Text = wahadlo.Y2.ToString();
            Canvas.SetLeft(Mass, Canvas.GetLeft(wahadlo) + wahadlo.X2 - Mass.ActualWidth/2);
            Canvas.SetTop(Mass, wahadlo.Y2 - Mass.ActualHeight/2);

            Vlin = omega * r;

            Vx = Math.Cos(teta) * Vlin;
            Vy = Math.Sin(teta) * Vlin;
           // Canvas.SetLeft(Vxy, Canvas.GetLeft(wahadlo) + wahadlo.X2);
            Vxy.X2 = - Vx + wahadlo.X2;
            Vxy.Y2 = Vy + wahadlo.Y2;

            t += dt;
            txtbTime.Text = t.ToString();
            txtbOmega.Text = omega.ToString();

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
