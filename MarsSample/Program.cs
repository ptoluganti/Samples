using System;
using System.Globalization;

namespace MarsSample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var actual = new Program().BrassDigits(500);
            for (var i = 0; i < actual.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, actual[i]);
            }
            Console.ReadKey();
        }


        /// <summary>
        ///     will take a number, and return an array with count for each digit.
        ///     -----------------------------------------
        ///     |   |   |   |   |   |   |   |   |   |   |
        ///     -----------------------------------------
        ///     0   1   2   3   4   5   6   7   8   9
        /// </summary>
        /// <param name="end"></param>
        /// <returns></returns>
        public double[] BrassDigits(double end)
        {
            var result = new double[10];

            if (end < 1)
            {
                throw new ArgumentOutOfRangeException(end + " should be greater than 0");
            }

            if (Math.Pow(10, 18) < end)
            {
                throw new ArgumentOutOfRangeException(end + " should be less than  (10^18)");
            }


            for (double i = 1; i <= end; i++)
            {
                var numString = i.ToString(CultureInfo.InvariantCulture);
                foreach (var item in numString)
                {
                    switch (item)
                    {
                        case '0':
                            result[0]++;
                            break;
                        case '1':
                            result[1]++;
                            break;
                        case '2':
                            result[2]++;
                            break;
                        case '3':
                            result[3]++;
                            break;
                        case '4':
                            result[4]++;
                            break;
                        case '5':
                            result[5]++;
                            break;
                        case '6':
                            result[6]++;
                            break;
                        case '7':
                            result[7]++;
                            break;
                        case '8':
                            result[8]++;
                            break;
                        case '9':
                            result[9]++;
                            break;
                    }
                }
            }

            return result;
        }
    }
}