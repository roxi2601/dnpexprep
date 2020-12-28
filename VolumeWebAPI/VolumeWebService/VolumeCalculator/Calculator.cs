using System;
using System.Threading.Tasks;
using VolumeWebAPI.Model;
using VolumeWebAPI.VolumeWebService.VolumeCalculator;

namespace VolumeWebAPI.VolumeWebService.VolumeCalculator{
    public class Calculator
    {
        private VolumeResult result;
        public double CalculateVolumeCylinder(double r, double h)
        { 
            double result = Math.PI * Math.Pow(r, 2) * h;
           return result ;
        }

        public  double CalculateVolumeCone(double r, double h)
        {
            double result = (1.0 / 3) * Math.PI * Math.Pow(r, 2) * h;
            return result;
        }
    }
}