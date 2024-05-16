using System;
using System.ComponentModel.DataAnnotations;

namespace DvidesimtDevinmtassProjektas
{
    public class Program
    {
        public static void Main(string[] args)

        /*Užduotis 29: While*/
        {
            int n = 0;
            Console.WriteLine($" Iveskite skaiciu");
            int Skaicius = int.Parse(Console.ReadLine());
            int Ilgis = Skaicius.ToString().Length;
            Console.WriteLine($"Ilgis {Ilgis}")
            ;
            {
               while (n< Skaicius)

                      Console.WriteLine(n);
                  n--;
              }
              Console.WriteLine($"Pirminis {Ilgis}");


            }
        }
    }
}

    














