using PendulumSimGraph.UserControls;
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
        
        double teta, t, dt, r, g;
        double omega;
        int tetaDeg;
        int tLimit;
        bool animationRunning = false;
        bool setValues = false;
        double Vlin;
        double Vx;
        double Vy;
        
        ObservableCollection<double> timeList = new ObservableCollection<double>();
        Point point0 = new Point(0, 0);
        Point point1 = new Point(0,0);

        PointLineGraph graph = new PointLineGraph();
        private Path myPath;

        public MainWindow()
        {
            InitializeComponent();
         

            r = 40;       //[m]
            g = 9.81f;    //[m/s^2]
            dt = 0.02f;
            tLimit = 1;

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
                Vxy.Visibility = Visibility.Visible;
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
            //timeList.Add(t);
            AddNewPath((omega * 100), (t*10));
            

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

        private void AddNewPath(double omega, double t)
        {
            point0 = point1;
            //Point tempPoint = new Point( t, omega);
            point1 = new Point (t, omega);

            

                myPath = new Path();
            myPath.Stroke = System.Windows.Media.Brushes.Black;
            myPath.Fill = System.Windows.Media.Brushes.MediumSlateBlue;
            myPath.StrokeThickness = 2;
            myPath.HorizontalAlignment = HorizontalAlignment.Left;
            myPath.VerticalAlignment = VerticalAlignment.Center;
            LineGeometry lineGeometry = new LineGeometry(point0, point1);
                myPath.Data = lineGeometry;
                drawGraph.Children.Add(myPath);
           

            
        }
    }
}
