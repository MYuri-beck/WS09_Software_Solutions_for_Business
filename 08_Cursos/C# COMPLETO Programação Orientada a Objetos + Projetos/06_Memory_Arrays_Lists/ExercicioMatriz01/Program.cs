using System;
using System.ComponentModel;

namespace ExercicioMatriz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tamanho da matriz?");
            int size = int.Parse(Console.ReadLine());

            int[,] matriz = new int[size, size];

            for (int i = 0; i < size; i++)
            {

                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < size; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);

                }
            }
            Console.WriteLine("Main diagonal: ");
            for (int k = 0; k < size; k++)
            {
                Console.Write(matriz[k, k] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Negative numbers: ");
            int negativeQuantity = 0;
            foreach (int number in matriz)
            {
                if (number < 0) { negativeQuantity++; Console.Write(number + ", "); }
            }
            Console.WriteLine();
            Console.WriteLine("Total of negative numbers: " + negativeQuantity);
        }
    }
}