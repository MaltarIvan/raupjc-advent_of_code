using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 277678;

            Console.WriteLine(DoMagic1(1));
            Console.ReadLine();

            Console.WriteLine(DoMagic1(12));
            Console.ReadLine();

            Console.WriteLine(DoMagic1(23));
            Console.ReadLine();

            Console.WriteLine(DoMagic1(1024));
            Console.ReadLine();

            Console.WriteLine(DoMagic1(input));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(1));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(12));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(23));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(25));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(747));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(1024));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(input));
            Console.ReadLine();
        }

        private static int DoMagic1(int input)
        {
            int x = 0;
            int y = 0;
            int k = 1;
            int i = 1;
            int n = 1;

            while (true)
            {
                if (n == input)
                {
                    break;
                }
                for (int j = 0; j < i; j++)
                {
                    x += k;
                    n++;
                    if (n == input)
                    {
                        break;
                    }
                }
                if (n == input)
                    {
                        break;
                    }
                for (int j = 0; j < i; j++)
                {
                    y += k;
                    n++;
                    if (n == input)
                    {
                        break;
                    }
                }
                if (n == input)
                {
                    break;
                }
                k *= -1;
                i++;
            }
            return Math.Abs(x) + Math.Abs(y);
        }

        private static int DoMagic2(int input)
        {
            int[,] matrix = new int[101, 101];

            int x = 101/2;
            int y = 101/2;
            int k = 1;
            int i = 1;
            int n = 0;

            matrix[50, 50] = 1;

            while (i < 100)
            {
                n = 0;
                for (int j = 0; j < i; j++)
                {
                    x += k;

                    if (x > 0 && y > 0)
                    {
                        n += matrix[x - 1, y - 1];
                    }
                    if (x > 0)
                    {
                        n += matrix[x - 1, y + 1];
                        n += matrix[x - 1, y];
                    }
                    if (y > 0)
                    {
                        n += matrix[x, y - 1];
                        n += matrix[x + 1, y - 1];
                    }
                    n += matrix[x + 1, y];
                    n += matrix[x, y + 1];
                    n += matrix[x + 1, y + 1];

                    if (n > input)
                    {
                        break;
                    }
                    matrix[x, y] = n;
                    n = 0;
                }
                if (n > input)
                {
                    break;
                }
                for (int j = 0; j < i; j++)
                {
                    y += k;

                    if (x > 0 && y > 0)
                    {
                        n += matrix[x - 1, y - 1];
                    }
                    if (x > 0)
                    {
                        n += matrix[x - 1, y + 1];
                        n += matrix[x - 1, y];
                    }
                    if (y > 0)
                    {
                        n += matrix[x, y - 1];
                        n += matrix[x + 1, y - 1];
                    }
                    n += matrix[x + 1, y];
                    n += matrix[x, y + 1];
                    n += matrix[x + 1, y + 1];

                    if (n > input)
                    {
                        break;
                    }
                    matrix[x, y] = n;
                    n = 0;
                }
                if (n > input)
                {
                    break;
                }
                k *= -1;
                i++;
            }
            return n;
        }
    }
}
