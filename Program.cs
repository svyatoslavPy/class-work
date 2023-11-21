namespace CSharpTutorials
{
    class Program
    {
        public static int Pow(int a, int b)
        {
            var result = 1;

            if (b == 0) return 0;

            for (int i = 0; i <= b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static int SumNumbers(int a, int b)
        {
            var result = 0;
            for (int i = a; i < b; i++)
            {
                result += i;
            }

            return result;
        }

        public static string isPerfectNumber(int number)
        {
            string messageIsPerfect = "Number is perfect";
            string messageNotIsPerfect = "Number not is perfect";

            var result = 0;

            if (number <= 0) return messageNotIsPerfect;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    result += i;
                }
            }

            return result == number ? messageIsPerfect : messageNotIsPerfect;
        }

        static void showInfo(int powNum, int sumNum, string perfectNum)
        {
            Console.WriteLine($"Result pow {powNum}");
            Console.WriteLine($"Sum numbers - {sumNum}");
            Console.WriteLine($"Perfect number - {perfectNum}");
        }

        static void Main(string[] args)
        {
            //  Написати функцію, яка приймає два параметри: основу ступеня та показник ступеня, та обчислює ступінь числа на основі отриманих даних.
            try
            {
                var resultPow = Pow(2, 3);
                var resultSumNumbers = SumNumbers(2, 5);
                var resultNumIsPerfect = isPerfectNumber(28);

                showInfo(resultPow, resultSumNumbers, resultNumIsPerfect);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Написати функцію, яка отримує як параметри 2 цілих числа і повертає суму чисел з діапазону між ними.


            //  Число називається досконалим,
            //  якщо сума всіх його дільників
            //  дорівнює йому самому.
            //  Напишіть функцію пошуку таких чисел у введеному інтервалі.


            // game cards
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("\t");
            Console.WriteLine("Welcome to Game Cards: ");

            const string makeHorizontal = "-";
            const string makeVertical = "|";
            const string space = " ";


            int num;

            string[] allCards =
            {
                "", "A ♣️", "2 ♣️", "3 ♣️", "4 ♣️", "5 ♣️", "6 ♣️", "7 ♣️", "8 ♣️", "9 ♣️", "10 ♣️", "11 ♣️", "12 ♣️",
                "13 ♣️",
                "A ♦️", "2 ♦️", "3 ♦️", "4 ♦️", "5 ♦️", "6 ♦️", "7 ♦️", "8 ♦️", "9 ♦️", "10 ♦️", "11 ♦️", "12 ♦️",
                "13 ♦️",
                "A ♥️", "2 ♥️", "3 ♥️", "4 ♥️", "5 ♥️", "6 ♥️", "7 ♥️", "8 ♥️", "9 ♥️", "10 ♥️", "11 ♥️", "12 ♥️",
                "13 ♥️",
                "A ♠️", "2 ♠️", "3 ♠️", "4 ♠️", "5 ♠️", "6 ♠️", "7 ♠️", "8 ♠️", "9 ♠️", "10 ♠️", "11 ♠️", "12 ♠️",
                "13 ♠️"
            };


            static void PrintElement(string element)
            {
                Console.Write(element);
            }


            void ShowCards(string suit)
            {
                if (suit.Contains("♣️") || suit.Contains("♠️"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (suit.Contains("♦️") || suit.Contains("♥️"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                for (int i = 0; i < 9; i++)
                {
                    if (i == 4)
                    {
                        Console.WriteLine($"{makeVertical}  {suit}  {makeVertical}");
                    }

                    if (i == 0 || i == 8)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            PrintElement(makeHorizontal);
                        }
                    }
                    else
                    {
                        PrintElement(makeVertical);


                        for (int j = 0; j < 7; j++)
                        {
                            PrintElement(space);
                        }

                        PrintElement(makeVertical);
                    }

                    Console.WriteLine();
                }
            }
            
            try
            {
                Console.WriteLine("\n");
                do
                {
                    Console.Write("Enter a number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                } while (num > 52);

                if (num == 0)
                {
                    throw new Exception("Not have card this cards");
                }
                ShowCards(allCards[num]);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            static void checkLuckyNumber(int ticket)
            {
                int k = ticket / 1000 / 10 / 10;
                int g = ticket / 1000 % 10;
                int f = ticket / 1000 % 100 / 10;
            
                int a = ticket % 10;
                int b = ticket % 100 / 10;
                int c = ticket % 1000 / 10 / 10;

                if ((k + g + f) == (a + b + c))
                {
                    Console.WriteLine("This lucky number");
                }
                else
                {
                    Console.WriteLine("This not lucky number");
                }
            }
            
            // task 4
            int ticket;
            try
            {
                do
                {
                    Console.WriteLine("Enter a your ticket: ");
                    ticket = Convert.ToInt32(Console.ReadLine());
                } while (Convert.ToString(ticket).Length < 6);
                checkLuckyNumber(ticket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

