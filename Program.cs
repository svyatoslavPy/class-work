using System;

namespace ClassWork
{
    class Program
    {

        static void Main(string[] args)
        {
            string ShowNumbers(params int[] numbers)
            {
                string num = "";
                foreach (int i in numbers)
                {
                    num += i;
                }

                return num;
            }
            
            // task 1
            Console.Write("Enter a second num: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a second num: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a third num: ");
            int num3 = Convert.ToInt32(Console.ReadLine());;
            
            Console.Write("Enter a fourth num: ");
            int num4 = Convert.ToInt32(Console.ReadLine());;
            

            string result = ShowNumbers(num1, num2, num3, num4);
            Console.WriteLine(result);
            
            
            // task 2
            // reverse сделать числа 
            Console.WriteLine("Введите шестизначное число: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            char[] reverseNumber = Convert.ToString(numbers).ToCharArray();
            Array.Reverse(reverseNumber);
            string reversed = string.Join("", reverseNumber);
            Console.WriteLine(reversed);

            
            // доп задания
            Console.WriteLine("Enter a first number with user");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter a second number with user");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter a three number with user");
            int userNum3 = Convert.ToInt32(Console.ReadLine());

            int sumUsers = userNum1 + userNum2 + userNum3;
            int avarageMath = sumUsers / 3;
            Console.WriteLine($"Cумма - {sumUsers}, medium avarage - {avarageMath}");

            // task 2
            Console.WriteLine("Enter a price one laptop: ");
            double priceLaptop = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a quantity laptop: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a procent discount: ");
            double discount = Convert.ToDouble(Console.ReadLine()); // 20%
            
            double products = (priceLaptop * quantity);
            double discountResult = (products / 100) * discount;
            double productsResult = products - discountResult;
          
            Console.WriteLine($"Ваша сумма корзины учитывая скидку - {productsResult}");
            
            
            // task 3
            //  Завдання 3.
             // Зарплата менеджера - 100 $ + 5% від продажів. Користувач вводить з клавіатури загальну суму угод менеджера протягом місяця. Порахувати підсумкову зарплату менеджера. 
             
            Console.WriteLine("Введите сумму со сделок за месяц: ");
            int managerSumTrade = Convert.ToInt32(Console.ReadLine());
            
            int salaryTrade = managerSumTrade / 100 * 5;
            int salaryManager = 100 + salaryTrade;
            Console.WriteLine(salaryManager);
            Console.WriteLine("Text from feature/task-2");
            Console.WriteLine(1 + 1);
        }
    }
}