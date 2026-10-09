using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
    internal class Program
    {
        static int Zbroji(int a, int b) {
            return a + b;
        }
        static double Povrsina(double a, double b) {
            return a * b;
        }
        static void Main(string[] args)
        {
            string izbor = "";
            do
            {
                Console.WriteLine("\n\nZadatak 1\nZadatak 2\nZadatak 3");
                Console.Write("\nUnesi broj zadatka: ");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        Zadatak1 ();
                        break;
                    case "2":
                        Zadatak2 ();
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }
            } while (izbor != "0");
        }

        static void Zadatak3()
        {
            Console.WriteLine("\n---------------Zadatak 1---------------\n");
            Console.Write("Upisi velicinu prve stranice: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Upisi velicinu druge stranice: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Površina pravokutnika je : " + Povrsina(a, b));
            Console.WriteLine("\n---------------------------------------\n");
        }

        static void Zadatak2()
        {
            Console.Write("Upisi prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Upisi drugi broj: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Razlika tih brojeva je: " + Oduzmi(a, b));
        }
        static void Zadatak1()
        {
            Console.Write("Upisi prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Upisi drugi broj: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj tih brojeva je: " + Zbroji(a, b));
        }
    }
}
