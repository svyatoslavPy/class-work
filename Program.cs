using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            try
            {
                int size = 6;
                int[] salaryCompany = new int[size];
                int sum = 0;
                int countMonth = 6;

                for (int i = 0; i < countMonth; i++)
                {
                    Console.Write("Enter a salary: ");
                    int salary = Convert.ToInt32(Console.ReadLine());

                    salaryCompany[i] = salary;
                }

                foreach (var item in salaryCompany)
                {
                    sum += item;
                }

                Console.WriteLine($"Total - {sum}");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           

            // TASK 2
            try
            {
                int size = 12;
                int[] salaryCompany2 = new int[size];
                var rnd = new Random();
                int min = int.MaxValue;
                int max = int.MinValue;

                const int countMonth = 12;
                const int rndMin = 100, rndMax = 2000;
               
        
                for (int i = 0; i < countMonth; i++)
                {
                    salaryCompany2[i] = rnd.Next(rndMin, rndMax);
                }

                for (int i = 0; i < salaryCompany2.Length; i++)
                {
                    if (salaryCompany2[i] <= min)
                    {
                        min = salaryCompany2[i];
                    }
                    if (salaryCompany2[i] >= max)
                    {
                        max = salaryCompany2[i];
                    }
                }
                Console.WriteLine("----");

                Console.WriteLine($"Min - {min}");
                Console.WriteLine($"Max - {max}");
                Console.WriteLine("----");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // TASK 3
            try
            {
                int size = 5;
                int[] numbers = new int[size];
                int[] numbersUpdate = new int[numbers.Length - 1];
                const int newValue = -1;


                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbersUpdate[i] = newValue;
                }


                foreach (int item in numbersUpdate)
                {
                    Console.WriteLine(item); // show
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}