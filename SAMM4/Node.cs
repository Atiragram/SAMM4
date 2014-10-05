using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMM4
{
    class Node
    {
        public enum States {Work, Repair};
        public double interval;
        public States state ;
        Statistics statistics;
        public double processingTime = 0;
        public double repairTime = 0;
        double Rn; double a; double m; double eta = 2;
        double Rd, Rr;
        double defectIntensity;
        double repairIntensity;

        public Node( Statistics _statistics, double _defectIntensity, double _repairIntensity, double a, double Rn, double m)
        {
            this.state = States.Work;
            this.statistics = _statistics;
            this.defectIntensity = _defectIntensity;
            this.repairIntensity = _repairIntensity;
            this.Rn = Rn;
            this.a = a;
            this.m = m;

        }

        public void Time()
        {
            

        }

        public double defectGenerator()
        {
            Rn = a * Rn % m;
            Rd = Rn / m; 
            interval = -1 / defectIntensity * Math.Log(Rd);
            return interval;
        }

        public double repairTimeGenerator()
        {
            Rn = a * Rn % m;
            Rr = Rn / m;
            double multiplR = 1;
            for (int i = 0; i < eta; i++)
            {
                multiplR *= Rr;
            }
            double value = -1 / repairIntensity * Math.Log(multiplR);
            return value;
        }
    }
}
