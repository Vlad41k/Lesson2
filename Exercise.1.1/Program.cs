using System;

namespace Exercise._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var rand = new Random();
            for (int i = 0; i < 6; i++) // цикл для создания 6 случайных чисел 
            {
                var temp = rand.Next(1, 10); // генерация чисел от 1 до 10
                if ((temp > 4) && (temp <= 7)) // проверка попадания числа в диапазон
                    sum += temp;
                Console.Write(temp + " ");
            }
            Console.WriteLine("\nCумма чисел, больших 4 и меньших или равных 7: " + sum); //вывод результата
        }
    }
}

