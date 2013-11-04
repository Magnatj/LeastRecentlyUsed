using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leastRecentlyUsed
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            //Se tiene en este caso una matriz de 4 x 4, just for testing
            int[,] lruMatrix = new int[4,4];
            while (continua)
            {
                try
                {
                    Console.Write("Access: ");
                    int reference = int.Parse(Console.ReadLine());

                    //Asigna los 1's a la fila correspondiente
                    for (int i = 0; i < 4; i++)
                    {
                        lruMatrix[reference, i] = 1;
                    }

                    //Asigna los 0's a la columna correspondiente
                    for (int i = 0; i < 4; i++)
                    {
                        lruMatrix[i, reference] = 0;
                    }

                    //Imprime la matriz
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write(lruMatrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                }

                catch
                {
                    Console.WriteLine("Porfavor ingrese un numero de 0 a 3");
                }
            }
            
        }
    }
}
