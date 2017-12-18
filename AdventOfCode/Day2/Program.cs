using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string fileName = Path.Combine(projectFolder, @"AdventOfCode\Day2\InputDay2.txt");
            string[] lines = InputGetter.GetInputText(fileName);

            string testFile = Path.Combine(projectFolder, @"AdventOfCode\Day2\TestInput.txt");
            string[] testLines = InputGetter.GetInputText(testFile);
            Console.WriteLine(DoMagic1(testLines));
            Console.ReadLine();

            Console.WriteLine(DoMagic1(lines));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(testLines));
            Console.ReadLine();

            Console.WriteLine(DoMagic2(lines));
            Console.ReadLine();
        }

        private static int DoMagic1(string[] lines)
        {
            int[] lineRes = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineNumbers = lines[i].Split('\t');
                int[] numbers = new int[lineNumbers.Length];
                for (int j = 0; j < lineNumbers.Length; j++)
                {
                    numbers[j] = Int32.Parse(lineNumbers[j].Trim());
                }
                lineRes[i] = GetMax(numbers) - GetMin(numbers);
            }
            int sum = 0;
            foreach (var i in lineRes)
            {
                sum += i;
            }
            return sum;
        }

        private static int GetMax(int[] input)
        {
            int max = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }
            return max;
        }

        private static int GetMin(int[] input)
        {
            int min = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                }
            }
            return min;
        }

        private static int DoMagic2(string[] lines)
        {
            int[] lineRes = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineNumbers = lines[i].Split('\t');
                int[] numbers = new int[lineNumbers.Length];
                for (int j = 0; j < lineNumbers.Length; j++)
                {
                    numbers[j] = Int32.Parse(lineNumbers[j].Trim());
                }
                lineRes[i] = FindDev(numbers);
            }
            int sum = 0;
            foreach (var i in lineRes)
            {
                sum += i;
            }
            return sum;
        }

        private static int FindDev(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length && i != j; j++)
                {
                    if (input[i] % input[j] == 0)
                    {
                        return input[i] / input[j];
                    }
                    else if (input[j] % input[i] == 0)
                    {
                        return input[j] / input[i];
                    }
                }
            }
            return 0;
        }
    }
}
