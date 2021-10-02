using System;

namespace Exercise._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true; // Переменная для хранения результата
            double digit; // Переменная для хранения первой цифры в числе
            int NumOfDigit = 0; // Переменная для хранения количества цифр ив числе
            var rand = new Random();
            var num = rand.Next(1,10000); // Генерация случайного числа от 1 до 10000
            Console.WriteLine("Исходное число: " + num); // Вывод иходного числа
            for (int i = num; i>0;i/=10)  // Определение количества цифр в числе
                NumOfDigit++;
            if (NumOfDigit != 1)
            {
                digit = (int)(num / Math.Pow(10, (NumOfDigit - 1))); // Определение первой цифры в числе
                for (int i = NumOfDigit; i > 0; i--) // Цикл для рассматривание каждой цифры в числе
                {
                    int temp = (int)(num % Math.Pow(10, (i)));
                    if (digit != (int)(temp / Math.Pow(10, (i - 1)))) // Сравнивание каждой цифры с первйо цифрой в числе
                    {
                        check = false;
                        break;
                    }
                }

            }
            if (check == true) // Вывод результата
                Console.WriteLine("Все цифры в числе одинаковы");
            else
                Console.WriteLine("В числе имеются различные цифры");
        }
    }
}
