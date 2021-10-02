using System;

namespace Exercise._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <=10; i++) 
                sum += 2 * i - 1; // расчет квадрата по формуле
            Console.WriteLine("Сумма 1^2+ 2^2+ 3^2+... + 10^2: " + sum); //вывод результата
        }
    }
}
