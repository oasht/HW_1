using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            double a = rand.Next(1, 50);
            double b = rand.Next(1, 50);
            char n;
            double res;
            WriteLine("Enter the action");
            n = Convert.ToChar(ReadLine());

            switch (n)
            {
                case ('+'):
                    {
                        res = a + b;
                        WriteLine(res);
                        break;
                    }
                case ('-'):
                    {
                        res = a - b;
                        WriteLine(res);
                        break;
                    }
                case ('*'):
                    {
                        res = a * b;
                        WriteLine(res);
                        break;
                    }

                case ('/'):
                    {
                        res = a / b;
                        WriteLine(res);
                        break;
                    }

                default:
                    WriteLine("Error!");
                    break;

            }

        }
    }
}

