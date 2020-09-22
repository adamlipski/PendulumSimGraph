using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace PendulumSimGraph.UserControls
{
    /// <summary>
    /// Interaction logic for PointLineGraph.xaml
    /// </summary>
    public partial class PointLineGraph : UserControl /*, INotifyPropertyChanged*/
    {


        public PointLineGraph()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Omega",
                    Values = new ChartValues<double> { 0 },
                    PointGeometry = null
                },
                //  new LineSeries
                //{
                //    Title = "Time",
                //    Values = new ChartValues<double> { 0 },
                //    PointGeometry = null
                //},

            };

            double temp = 0;
            Time = new[] { (double)0 };
            YFormatter = value => value.ToString();

            //modifying the series collection will animate and update the chart


            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add((double)2);


            Time.Append(20d);
            Time.Append(330d);

            SeriesCollection[0].Values.Add((double)5);
            

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public double [] Time { get; set; }
        public Func<double, string> Formatter { get; }
        public Func<double, string> YFormatter { get; set; }

    }
}