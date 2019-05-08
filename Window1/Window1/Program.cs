using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Window1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            string[] temp = File.ReadAllLines(@"H:\temp.txt");
            long value = Convert.ToInt64(temp[0]);
            long num = value;
            string stringNum = Convert.ToString(num);

            while ((num < value * 2) || (prime == false))
            {
                prime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if ((num % i) == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime == true)
                {
                    Console.WriteLine(num);
                }

                if (num + 1 < value * 2)
                {
                    num++;
                }
                else
                {
                    break;
                }
                stringNum = Convert.ToString(num);

            }
            Console.ReadLine();
        }
    }
}
