using System;

namespace ClassWork
{
    class Program
    {

        static void Main(string[] args)
        {
            // TASK 1
            
            /*Console.WriteLine("Введите 5 оценок студента: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            int mark2 = Convert.ToInt32(Console.ReadLine());
            int mark3 = Convert.ToInt32(Console.ReadLine());
            int mark4 = Convert.ToInt32(Console.ReadLine());
            int mark5 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int averageMark = 0;
            
            List<int> marks = new List<int>(); //  {} инициализация по умолчанию
            
            // добавляем оценки в массив всех оценок студента
            marks.AddRange(new [] 
            {
                mark1, mark2, mark3, mark4, mark5
            });

            foreach (int item in marks) // через foreach пробегаемся по коллекции и суммируем
            {
                sum += item;
            }
            

            averageMark = sum / marks.Count;
            if (averageMark >= 4)
            {
                Console.WriteLine("Студента допущено к экзамену");
            }
            else
            {
                Console.WriteLine("К сожалению студента не допущено к экзамену");
            }*/
            
            
             Console.WriteLine("Введите 5 оценок студента: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            int mark2 = Convert.ToInt32(Console.ReadLine());
            int mark3 = Convert.ToInt32(Console.ReadLine());
            int mark4 = Convert.ToInt32(Console.ReadLine());
            int mark5 = Convert.ToInt32(Console.ReadLine());
            
            int sum = mark1 + mark2 + mark3 + mark4 + mark5;
            int averageMark = sum / 5;


            if (averageMark >= 4)
            {
                Console.WriteLine("Студента допущено к экзамену");
            }
            else
            {
                Console.WriteLine("К сожалению студента не допущено к экзамену");
            }

            Console.WriteLine("-----------");
            
            // TASK 2
            Console.WriteLine("Введите число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            
            if (userNumber % 2 == 0)
            {
                result = userNumber * 3;
            }
            else
            {
                result = userNumber / 2;
            }

            Console.WriteLine($"Результат {result}");
            Console.WriteLine("-----------");
            
            // TASK 3 ( CALC )
            Console.Write("Введите первое число для расчета: ");
            int calcFirstNum = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите второе число для расчета: ");
            int calcSecondNum = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите операцию (знак) для расчета: ");
            string calcOperation = Console.ReadLine() ?? string.Empty;
            
            void Calc(int firstNum, int secondNum, string operation)
            {
                if (operation == "+")
                {
                    Console.WriteLine(firstNum + secondNum);
                } 
                else if (operation == "-")
                {
                    Console.WriteLine(firstNum - secondNum);
                } 
                else if (operation == "*")
                {
                    Console.WriteLine(firstNum * secondNum);
                }
                else if (operation == "/")
                {
                    Console.WriteLine(firstNum / secondNum);
                }
                else
                {
                    Console.WriteLine("Неверная операция, повторите еще раз");
                }
            }

            Calc(calcFirstNum, calcSecondNum, calcOperation);



            // Дополнительные задания
            Console.WriteLine("Введите уровень продаж для 3 менеджеров: ");
            int manager1 = Convert.ToInt32(Console.ReadLine());
            int manager2 = Convert.ToInt32(Console.ReadLine());
            int manager3 = Convert.ToInt32(Console.ReadLine());
            int managerSalary1 = 0, managerSalary2 = 0, managerSalary3 = 0;

            int CalcSalaryManagers(int manager) // функция - это именованный блок кода который выполняет определенное действие и решает проблему переиспользование кода 
            {
                if (manager <= 500)
                {
                    return 200 + (manager / 100 * 3);
                }

                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                if (manager >= 500 && manager <= 1000)
                {
                    return 200 + (manager / 100 * 5);
                }
                
                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                if (manager > 1000)
                {
                    return 200 + (manager / 100 * 8);
                }

                return 0;
            }
            // (mager1 > manager2) && (manager2 > manager3) || (mana
            managerSalary1 = CalcSalaryManagers(manager1); 
            managerSalary2 = CalcSalaryManagers(manager2); 
            managerSalary3 = CalcSalaryManagers(manager3); 

            string bestManager = String.Empty;
            
            if (manager1 >= manager2 && manager3 <= manager2 && manager2 <= manager3)
            {
                managerSalary1 += 200;
                bestManager = "Первый";
            } 
            else if (manager2 >= manager1 && manager3 <= manager2)
            {
                managerSalary2 += 200;
                bestManager = "Второй";
            } 
            else if (manager3 >= manager2 && manager1 <= manager2)
            {
                managerSalary3 += 200;
                bestManager = "Третий";
            }

            Console.WriteLine("Лучший менеджер: " + "" + bestManager);
            
            Console.WriteLine("Зарплата первого менеджера - " + "" + managerSalary1);
            Console.WriteLine("Зарплата второго менеджера - " + "" + managerSalary2);
            Console.WriteLine("Зарплата третьего менеджера - " + "" + managerSalary3);
            
            


        }
    }
}