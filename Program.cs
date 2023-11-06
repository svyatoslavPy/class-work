using System;

namespace ClassWork
{
    class Program
    {
        enum CalcOperations
        {
            Plus = '+',
            Minus = '-',
            Myltiply = '*',
            Division = '/'
        }

        enum CodePizza
        {
            Margaritha = 3,
            Spicy = 2,
            Mexico = 4
        }
        
        enum PricePizza
        {
            Margaritha = 8,
            Spicy = 9,
            Mexico = 10
        }

        enum CodeDrinks
        {   
            Cola = 1,
            Sprite = 2,
            Fanta = 3
        }

        enum PriceDrinks
        {
            Cola = 2,
            Sprite = 1,
            Fanta = 3
        }
        
   

        static void Main(string[] args)
        {
            // task 1
            try
            {
                Console.Write("Введите первое число: ");
                int firstNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Выберите операцию: ( +, /, */ - ): ");
                char operation = Convert.ToChar(Console.ReadLine() ?? string.Empty);

                switch (operation)
                {
                    case (char)CalcOperations.Plus:
                        Console.WriteLine(firstNum + secondNum);
                        break;
                    case (char)CalcOperations.Minus:
                        Console.WriteLine(firstNum - secondNum);
                        break;
                    case (char)CalcOperations.Division:
                        if (secondNum == 0)
                        {
                            throw new DivideByZeroException("You dont divide at zero, please!!!");
                        }

                        Console.WriteLine(firstNum / secondNum);
                        break;
                    case (char)CalcOperations.Myltiply:
                        Console.WriteLine(firstNum * secondNum);
                        break;
                    default:
                        throw new Exception("Not correctly this operation");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            // TASK 2

            Console.WriteLine("Welcome to our pizza cafe! ");
            Console.Write("Are you need menu for choise pizza ( Yes or No ): ");

            static void PrintMenu()
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Pizza: ");
                Console.WriteLine("Pizza Margaritha, code - 3");
                Console.WriteLine("Pizza Spicy, code - 2");
                Console.WriteLine("Pizza Mexico, code - 4");
                Console.WriteLine("Drinks: ");
                Console.WriteLine("Coca-cola, code - 1");
                Console.WriteLine("Sprite, code - 2");
                Console.WriteLine("Fanta, code - 3");
            }

            
            static void Menu()
            {
                try
                {
                    PrintMenu();
                    Console.Write("Enter a code for choise pizza: ");
                    int choisePizza = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter a quantity pizza: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter a code for choise drink: ");
                    int choiseDrink = Convert.ToInt32(Console.ReadLine());

                    double resultPrice = 0;
                    double discount = 0;
                    string namePizza = string.Empty;

                    if (choisePizza == (int)CodePizza.Margaritha)
                    {
                        resultPrice = quantity * (int)PricePizza.Margaritha;
                        namePizza = "Pizza Margaritha";
                    }
                    else if (choisePizza == (int)CodePizza.Spicy)
                    {
                        resultPrice = quantity * (int)PricePizza.Spicy;
                        namePizza = "Pizza Spicy";
                    }
                    else if (choisePizza == (int)CodePizza.Mexico)
                    {
                        resultPrice = quantity * (int)PricePizza.Mexico;
                        namePizza = "Pizza Mexico";
                    }
                    else
                    {
                        throw new Exception("Not correctly code");
                    }

                    if (choiseDrink > 0)
                    {
                        if (choiseDrink == (int)CodeDrinks.Cola)
                        {
                            resultPrice += (int)PriceDrinks.Cola;
                        }
                        else if (choiseDrink == (int)CodeDrinks.Sprite)
                        {
                            resultPrice += (int)PriceDrinks.Sprite;
                        }
                        else if (choiseDrink == (int)CodeDrinks.Fanta)
                        {
                            resultPrice += (int)PriceDrinks.Fanta;
                        }
                        else
                        {
                            throw new Exception("Not correctly code");
                        }
                    }

                    if (resultPrice > 50)
                    {
                        discount = resultPrice / 100 * 20;
                    }

                    if (quantity % 5 == 0)
                    {
                        quantity += 1;
                    }

                    Console.WriteLine($"Name - {namePizza}, Quantity - {quantity}, Price - {resultPrice - discount}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            string choise = Console.ReadLine() ?? string.Empty;
            bool showMenu = choise.ToLower() == "yes";


            if (showMenu)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("When you are ready to order, say to me");
            }
        }
    }
}