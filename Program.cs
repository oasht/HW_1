using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
           
            string q;
            do
            {
                Title = "Calculator";
                n = Convert.ToChar(ReadLine());
                Clear();
                switch (n)
                {
                   
                    case ('+'):
                        {
                            res = a + b;
                            WriteLine(a + "+" + b + " = "+res) ;
                            break;
                        }
                    case ('-'):
                        {
                            res = a - b;
                            WriteLine(a + "-" + b + " = " + res);
                            break;
                        }
                    case ('*'):
                        {
                            res = a * b;
                            WriteLine(a + "*" + b + " = " + res);
                            break;
                        }

                    case ('/'):
                        {
                            res = a / b;
                            WriteLine(a + "/" + b + " = " + res);
                            break;
                        }

                    default:
                        WriteLine("Error!");
                        break;

                }
                Thread.Sleep(3000);
                Clear();
                WriteLine("Press 1 to continue");
                q=ReadLine();
                Clear();
            } while (q=="1");

        }
    }
}

