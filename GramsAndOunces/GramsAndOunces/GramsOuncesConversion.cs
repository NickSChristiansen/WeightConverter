using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GramsAndOunces
{
    /// <summary>
    /// Conversion between grams and ounces
    /// </summary>
    public static class GramsOuncesConversion
    {
        private const double CONVERSIONCONSTANT = 28.34952;
        private const string NegativeError = "Must be a non-negative number";

        /// <summary>*
        /// Converts grams to ounces.
        /// </summary>
        /// <param name="grams"> Weight in grams (g)</param>
        /// <returns>Weight in ounces (oz)</returns>
        public static double GramsToOunces(double grams)
        {
            if (grams < 0)
            {
                throw new ArgumentOutOfRangeException(NegativeError);
            }

            return grams / CONVERSIONCONSTANT;
        }

        /// <summary>
        /// Converts ounces to grams.
        /// </summary>
        /// <param name="ounces"> Weight in ounces (oz)</param>
        /// <returns>weight in grams</returns>
        public static double OuncesToGrams(double ounces)
        {
            if (ounces < 0)
            {
                throw new ArgumentOutOfRangeException(NegativeError);
            }

            return ounces * CONVERSIONCONSTANT;
        }
    }
}
