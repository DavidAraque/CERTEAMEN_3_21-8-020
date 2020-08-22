using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
                int n;
                Console.WriteLine("Ingrese el Vector N");
                Console.Write("N: ");
                n = Convert.ToInt32(Console.ReadLine());



                int[] vec = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\nvector[" + (i + 1) + "]=  ");
                    vec[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\n\nEl vector ingresado por el usuario es: \n");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(" " + vec[i]);
                }

                // Ordenar vector, metodo burbuja
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (vec[j] > vec[j + 1])
                        {
                            int aux = vec[j];
                            vec[j] = vec[j + 1];
                            vec[j + 1] = aux;
                        }
                    }
                }

                Console.WriteLine("\n\nEl elemento menor del vector es: " + vec[0]);
                Console.WriteLine("\nEl elemento mayor del vector es: " + vec[n - 1]);
                Console.WriteLine("\nEl vector ordenado es: \n");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(" " + vec[i]);
                }

                Console.WriteLine("Hasta la proxima.");
                Console.ReadKey();
            }
        }
    }

    

