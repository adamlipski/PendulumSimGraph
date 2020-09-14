using System;
using System.Collections.Generic;
using System.Text;

namespace PendulumSimGraph
{
    public class PendulumSim
    {
        public double Omega { get; set; }

        public double Teta { get; set; }

        public double TimeStep { get; set; }

        public double Radius { get; set; }



        public PendulumSim(double omega, double teta, double dt, double r)
        {
            Omega = omega;
            Teta = teta;
            TimeStep = dt;
            Radius = r;


        }


    }
}
