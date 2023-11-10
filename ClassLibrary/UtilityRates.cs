using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UtilityRates
    {
        private double[] rates;

        public UtilityRates(double heatingRate, double waterRate, double gasRate, double maintenanceRate)
        {
            rates = new double[4];
            rates[0] = heatingRate;
            rates[1] = waterRate;
            rates[2] = gasRate;
            rates[3] = maintenanceRate;
        }

        public double this[int index]
        {
            get { return rates[index]; }
            set { rates[index] = value; }
        }
    }
}
