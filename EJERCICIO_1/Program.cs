using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese La Matriz NxN");
            Console.Write("\nEntrada de un solo digito\n");
            Console.Write("El tamaño de la matiz es de: ");
            n = Convert.ToInt32(Console.ReadLine()); ;



            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\nmat[" + (i + 1) + "][" + (j + 1) + "] = ? ");
                    mat[i, j] = Convert.ToInt32(Console.ReadLine()); ;
                }
            }

            // Aplicar las secuencias a la Matriz
            Console.Write("\n\n Prueba de Primera Secuencia\n");
            for (int j = 0; j < n; j++)
            {
                Console.Write(" " + mat[0, j]);
            }

            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if ((i > 0) && (i < n - 1) && ((j == 0) || (j == n - 1)))
                    {
                        Console.Write(" " + mat[i, j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
            }

            Console.Write("\n");
            for (int j = 0; j < n; j++)
            {
                Console.Write(" " + mat[n - 1, j]);
            }

            Console.Write("\n\nPrueba de Segunda Secuencia\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if ((i == j) || (i == (n - 1) - j))
                    {
                        Console.Write(" " + mat[i, j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
            }

            Console.Write("\n\nPrueba de Tercera Secuencia\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" " + mat[i, j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }

            Console.Write("\n\nPrueba de Cuarta Secuencia\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(" " + mat[i, j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
            }

            // Aplicar las secuencias a la Matriz
            Console.Write("\n\n Implementada Primera Secuencia\n");
            for (int j = 0; j < n; j++)
            {
                Console.Write(" 1");
            }

            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if ((i > 0) && (i < n - 1) && ((j == 0) || (j == n - 1)))
                    {
                        Console.Write(" 1");
                    }
                    else
                    {
                        Console.Write(" 0");
                    }
                }
            }

            Console.Write("\n");
            for (int j = 0; j < n; j++)
            {
                Console.Write(" 1");
            }

            Console.Write("\n\n Implementada Segunda Secuencia\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if ((i == j) || (i == (n - 1) - j))
                    {
                        Console.Write(" 1");
                    }
                    else
                    {
                        Console.Write(" 0");
                    }
                }
            }

            Console.Write("\n\n Implementada Tercera Secuencia\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" 1");
                    }
                    else
                    {
                        Console.Write(" 0");
                    }
                }
                Console.Write("\n");
            }

            Console.Write("\n\nImplementada Cuarta Secuencia\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(" 1");
                    }
                    else
                    {
                        Console.Write(" 0");
                    }
                }
            }

            Console.WriteLine("\n\nHasta la proxima...\n");
            Console.ReadKey();
        }
    }
}
        
    

