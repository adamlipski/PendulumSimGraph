using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

    
        public class MyDouble : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private double _Value;
            public double Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }

            void OnPropertyChanged(string propertyName)
            {
                var handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }

        }
        ObservableCollection<MyDouble> Arr { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Arr.Add(x_p);
            point.Add(y_p);
            rysownik.DataContext = point;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PendulumSim pendulum = new PendulumSim(
                Convert.ToDouble(txtbOmega.Text),
                Convert.ToDouble(txtbTeta.Text),
                Convert.ToDouble(txtbdt.Text),
                Convert.ToDouble(txtbRadius.Text));
                
                
            x_p = Convert.ToDouble(Xp.Text.ToString());
            y_p = Convert.ToDouble(Yp.Text.ToString());

            point[0] = x_p;
            point[1] = y_p;
            
            
        }



    }
}
