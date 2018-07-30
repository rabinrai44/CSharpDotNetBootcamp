using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles.Library
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private  double Radius { get; set; }

        //Calculate the Circumference
        public double CalculateCircumference()
        {
            var circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        //Calculate the formatted circumference
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        //Calculate the area of circle
        public double CalculateArea()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }

        //Calculate the formatted area of circle
        public string CalculateFormattedArea()
        {
           return FormatNumber(CalculateArea());
        }

        //Format the number
        private string FormatNumber(double x)
        {
            return $"{x:N}";
        }


    }
}
