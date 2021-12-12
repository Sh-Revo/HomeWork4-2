using System;

namespace HomeWork4_2
{
    class Program
    {
        static int Task1(int[,] mas)
        {
            int min = mas[0,0];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i,j] < min)
                    {
                        min = mas[i,j];
                    }
                }
            }

            return min;
        }

        static int Task2(int[,] mas)
        {
            int max = mas[0,0];

            for (int i = 0;i < mas.GetLength(0); i++)
            {
                for (int j = 0;j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i,j];
                    }
                }
            }

            return max;
        }

        static (int, int) Task3(int[,] mas)
        {
            (int, int) indexMin  = (0, 0);
            int min = mas[0, 0];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        indexMin = (i, j);
                    }
                }
            }

            return indexMin;
        }

        static (int, int) Task4(int[,] mas)
        {
            (int, int) indexMax = (0, 0);
            int max = mas[0, 0];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        indexMax = (i, j);
                    }
                }
            }

            return indexMax;
        }

        static int[,] Task6(int[,] mas)
        {
            int t;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    t = mas[i, j];
                    mas[i, j] = mas[j, i];
                    mas[j, i] = t;
                }
            }

            return mas;
        }

        //antidiagonal
        static int[,] Task7(int[,] mas)
        {
            int t;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < (mas.GetLength(0) - 1) - i; j++)
                {
                    t = mas[i, j];
                    mas[i, j] = mas[mas.GetLength(0) - 1 - j, mas.GetLength(0) - 1 -i];
                    mas[mas.GetLength(0) - 1 - j, mas.GetLength(0) - 1 - i] = t;
                }
            }

            return mas;
        }

        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-10, 10);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Console.WriteLine(Task1(array));
            //Console.WriteLine(Task2(array));
            //Console.WriteLine(Task3(array));
            //Console.WriteLine(Task4(array));
            Console.WriteLine(Task6(array));
            //Console.WriteLine(Task7(array));
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
