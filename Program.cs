using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            try
            {
                int countNumberMultipleOfFive = 0;
                int start = 0;
                int end = 0;

                do
                {
                    Console.Write("Enter a start: ");
                    start = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter a end: ");
                    end = Convert.ToInt32(Console.ReadLine());
                } while ((start <= 0 || end <= 0));

                Console.WriteLine("Number all in range: ");
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);

                    if (i % 7 == 0)
                    {
                        Console.WriteLine(i);
                    }

                    if (i % 5 == 0)
                    {
                        countNumberMultipleOfFive++;
                    }
                }

                Console.WriteLine($"Count number multiple of five - {countNumberMultipleOfFive}");
                Console.WriteLine("Number less: ");

                for (int i = end; i >= start; i--)
                {
                    Console.Write(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not correct, again write number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // task 2
            try
            {
                Console.WriteLine();
                Console.WriteLine("Enter a number: ");

                int evenCount = 0;
                int oddCount = 0;
                int countNumberMultipleOfNine = 0;
                int sumEven = 0;
                int sumOdd = 0;
                int sumMultipleOfNine = 0;


                for (int i = 0; i < 2; i++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (i % 2 == 0)
                    {
                        sumEven += number;
                        evenCount++;
                    }

                    if (i % 2 != 0)
                    {
                        sumOdd += number;
                        oddCount++;
                    }

                    if (i % 9 == 0)
                    {
                        sumMultipleOfNine += number;
                        countNumberMultipleOfNine++;
                    }
                }

                Console.WriteLine($"Even, sum - {sumEven}, avarage - {sumEven / evenCount}");
                Console.WriteLine($"Odd, sum - {sumOdd}, avarage - {sumOdd / oddCount}");
                Console.WriteLine(
                    $"MultipleOfNine, sum - {sumMultipleOfNine}, avarage - {sumMultipleOfNine / countNumberMultipleOfNine}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // additionally
            // task
            try
            {
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    if (n >= 100)
                    {
                        break;
                    }

                    Console.Write("Enter a number: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i <= n; i++)
                    if (i % n == 0 && i % 1 == 0)
                    {
                        Console.WriteLine(i);
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}