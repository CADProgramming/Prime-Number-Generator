using System;
using System.IO;
using System.Diagnostics;
using System.Numerics;

namespace PrimeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.Write("______Prime Number Application______\n\n[1] Prime Checker\n[2] Prime Finder\n[3] Close\n\nEnter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrimeCheck();
                        break;
                    case 2:
                        PrimeFind();
                        break;
                }
            } while (choice != 3);
        }
        
        static void PrimeCheck()
        {
            bool prime = true;
            
            Console.Write("Enter a number: ");
            BigInteger user = BigInteger.Parse(Console.ReadLine());

            for (BigInteger i = 2; Convert.ToDouble(i) <= Math.Exp(BigInteger.Log(user) / 2); i++)
            {
                if ((user % i) == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime == true)
            {
                Console.WriteLine($"{user} is a prime number\n");
            }
            else
            {
                Console.WriteLine("Not prime\n");
            }
        }

        static void PrimeFind()
        {
            BigInteger num = 1;
            string stringNum = Convert.ToString(num);
            bool prime = true;

            Console.Write("Enter the length in digits (MAX OF 16): ");
            int limit = Convert.ToInt32(Console.ReadLine());

            BigInteger value = BigInteger.Pow(10, limit-1)/4;

            if (File.Exists(@"H:\temp.txt"))
            {
                File.Delete(@"H:\temp.txt");
                File.Create(@"H:\temp.txt").Close();
                File.AppendAllText(@"H:\temp.txt", value.ToString());
            }
            else
            {
                File.Create(@"H:\temp.txt").Close();
                File.AppendAllText(@"H:\temp.txt", value.ToString());
            }

            Process.Start(@"H:\My Documents\Course_Work\IN510_Programming_1\Window1\Window1\bin\Debug\Window1.exe");
            Process.Start(@"H:\My Documents\Course_Work\IN510_Programming_1\Window2\Window2\bin\Debug\Window2.exe");
            Process.Start(@"H:\My Documents\Course_Work\IN510_Programming_1\Window3\Window3\bin\Debug\Window3.exe");

            while ((num < value) || (prime == false))
            {
                prime = true;

                for (int i = 2; i <= BigInteger.Pow(num, (1/2)); i++)
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

                if (num + 1 < value)
                {
                    num++;
                }
                else
                {
                    break;
                }
                stringNum = Convert.ToString(num);
                
            }
        }
    }
}
