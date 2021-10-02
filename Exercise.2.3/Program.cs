using System;

namespace Exercise._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double digit; // Переменная для хранения первой цифры в числе
            int NumOfDigit = 0; // Переменная для хранения количества цифр ив числе
            int max = 0, min = 0; // Переменные для наибольшей и найменьшей цифр в числе
            var rand = new Random();
            var num = rand.Next(1, 10000); // Генерация случайного числа от 1 до 10000
            int a = rand.Next(1,5); // Число для проверки кратности 
            Console.WriteLine("Исходное число: " + num); // Вывод иходного числа
            for (int i = num; i > 0; i /= 10)  // Определение количества цифр в числе   
                NumOfDigit++;
            digit = (int)(num / Math.Pow(10, (NumOfDigit - 1))); // Определение первой цифры в числе
            max = min = (int)digit; 
            if (NumOfDigit != 1)
            {
                for (int i = NumOfDigit; i > 0; i--) // Цикл для рассматривание каждой цифры в числе
                {
                    int temp = (int)(num % Math.Pow(10, (i)));
                    if (max < (int)(temp / Math.Pow(10, (i - 1)))) // Сравнивание наибольшей цифры с текущей
                        max = (int)(temp / Math.Pow(10, (i - 1)));
                    if (min > (int)(temp / Math.Pow(10, (i - 1)))) // Сравнивание наименьшей цифры с текущей
                        min = (int)(temp / Math.Pow(10, (i - 1)));
                }

            }
                if ((max+min)%a==0) // Вывод результата
                    Console.WriteLine("Сумма максимальной и минимальной цифры в числе кратна числу " + a);
                else
                    Console.WriteLine("Сумма максимальной и минимальной цифры в числе не кратна числу " + a);
        }
    }
}
