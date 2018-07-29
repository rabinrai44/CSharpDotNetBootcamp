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
            var formatted = Math.Round(CalculateCircumference(), 2);
            return ((double)formatted).ToString();
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
            //lLttle different method that format and return the value only 2 decimal places
            //can use Math.Round() function as well
            var formattedArea = string.Format("{0:0.00}", CalculateArea()).ToString();

            if (formattedArea.EndsWith("00"))
            {
                return ((double)CalculateArea()).ToString();
            }
            else
            {
                return formattedArea;
            }
        }

        //Format the number
        //private string FormatNumber(double x)
        //{
          
        //}


    }
}
