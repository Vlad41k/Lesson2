using System;

namespace Exercise._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstDigit; // Переменная для хранения первой цифры в числе
            double LastDigit; // Переменная для хранения последней цифры в числе
            int NumOfDigit = 0; // Переменная для хранения количества цифр ив числе
            double sum = 0; // Переменная для хранения результата
            var rand = new Random();
            int num = rand.Next(1,100000);
            for (int i = num; i > 0; i /= 10)  // Определение количества цифр в числе
                NumOfDigit++;
            FirstDigit = (int)(num / Math.Pow(10, (NumOfDigit - 1))); // Расчет первой цифры в числе
            LastDigit = num % 10; // Расчет последней цифры в числе
            sum = FirstDigit + LastDigit; // Расчет суммы
            Console.WriteLine("Заданное число: " + num);
            Console.WriteLine("Сумма первой и последней цифры в числе: " + sum);
        }
    }
}
