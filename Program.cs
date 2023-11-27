namespace App
{
    class Program
    {

        /*
         *
         *  for (int i = 0; i < numbers.Length; i++) 
                // пробегаемся повверх циклом
                // для того чтобы повторить
                // сортировку такое кол-во раз
                // сколько у нас всего элементов в массиве
            {
                for (int j = 0; j < numbers.Length - i - 1; j++) 
                    // пробегаемся по массиву и
                    // на каждой итерации сдвигаем
                    // и также на шаг меньше чтобы
                    // сорт заканчивался
                    // на предпоследнем элементе
                {
                    if (numbers[j] > numbers[j + 1]) // если текущее число больше чем то которое спереди
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]); // swap
                    }
                }
            }
         *
         * 
         */
        static Random CreateRandomNumber()
        {
            var rnd = new Random();
            return rnd;
        }

        static int[] InitRandomNumbers(int[] numbers, int start = 1, int end = 100)
        {
            var rnd = CreateRandomNumber();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(start, end);
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            int sizeNumbers = 30;
            int[] numbers = new int[sizeNumbers];
            InitRandomNumbers(numbers);

            // BUBLE SORT
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++) {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

