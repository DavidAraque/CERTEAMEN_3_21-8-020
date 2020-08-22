using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Cantidad de diferentes datos a guardar: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nIngrese los datos:\n");

            // Matriz nx4 de 100 caracteres de longitud
            String[,] strmat = new String[n, 4];

            int canthom = 0;
            int cantmuj = 0;
            int cantmay = 0;
            int cantmen = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNOMBRE: ");
                strmat[i, 0] = Console.ReadLine();

                Console.Write("\nAPELLIDO: ");
                strmat[i, 1] = Console.ReadLine();

                Console.Write("\nSEXO[F/M]:  ");
                strmat[i, 2] = Console.ReadLine().ToUpper();

                if (String.Compare(strmat[i, 2], "F") == 0)
                {
                    cantmuj++;
                }
                else if (String.Compare(strmat[i, 2], "M") == 0)
                {
                    canthom++;
                }

                Console.Write("\nAÑO de NACIMIENTO:  ");
                strmat[i, 3] = Console.ReadLine();

                if (String.Compare(strmat[i, 3], "2002") <= 0)
                {
                    cantmay++;
                }
                else if (String.Compare(strmat[i, 3], "2002") > 0)
                {
                    cantmen++;
                }
            }

            Console.WriteLine("\n\nLosDatos registrados\n\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n\nIndice: " + (i + 1));
                Console.Write("\nNombre: " + strmat[i, 0]);
                Console.Write("\nApellido: " + strmat[i, 1]);
                Console.Write("\nSexo: " + strmat[i, 2]);
                Console.Write("\nAÑO deNacimiento: " + strmat[i, 3]);
            }

            Console.Write("\n\nResumen");
            Console.Write("\nCantidad Mujeres: " + cantmuj);
            Console.Write("\nCantidad Hombres: " + canthom);
            Console.Write("\n\nCantidad Mayores de edad: " + cantmay);
            Console.Write("\nCantidad Menores de edad: " + cantmen);

            Console.WriteLine("Hasta la proxima");
            Console.ReadKey();
        }
    }
}
