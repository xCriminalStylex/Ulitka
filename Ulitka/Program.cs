using System;

namespace Ulitka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int num = 1;
            for( i = 0; i < n; i++)
            {
                for( j = 0; j < n; j++)
                {
                    array[i, j] = num;
                    Console.Write(num);
                    Console.Write(" ");
                    num++;
                }
                Console.WriteLine();
            }
            int xmin = 0;
            int xmax = n - 1;
            int ymin = 0;
            int ymax = n - 1;
            int counter = 0;
            while (counter < n * n)
            {
                for (j = xmin, i = ymin; j <= xmax; j++)
                {
                    Console.WriteLine(array[i, j]);
                    counter++;
                }
                ymin++;
                for (j = xmax, i = ymin; i <= ymax; i++)
                {
                    Console.WriteLine(array[i, j]);
                    counter++;
                }
                xmax--;
                for (j = xmax, i = ymax; j >= xmin; j--)
                {
                    Console.WriteLine(array[i, j]);
                    counter++;
                }
                ymax--;
                for (j = xmin, i = ymax; i >= ymin; i--)
                {
                    Console.WriteLine(array[i, j]);
                    counter++;
                }
                xmin++;
            }
        }
    }
}
