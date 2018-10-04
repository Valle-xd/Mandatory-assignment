using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Mandatory_assignment
{
    public class Converterdll
    {
        private const double Ounces = 28.34952;
        private const double Grams = 0.03527396195;


        public static double Ounces2Grams(double ounces)
        {
            return ounces * Ounces;
        }
  
        public static double Grams2Ounces(double grams)
        {
            return grams * Grams;
        }
    }
}
