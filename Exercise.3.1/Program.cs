using System;

namespace Exercise._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var num = rand.Next(5,10); 
            var mass = new double[(int)num]; // Создание массива размерностью от 5 до 10 ячеек
            for (int i = 0; i < num; i++) // Заполнение массива
                mass[i] = Math.Round(rand.NextDouble()*10,2);
            Console.Write("Исходный массив: ");
            for (int i = 0; i < num; i++) // Вывод исходного массива
                Console.Write(mass[i] + " ");
            for (int i = 1; i < num; i++) // Деление каждого элемента массива на первый элемент
                mass[i] /= mass[0];
            Console.Write("\nРезультирующий массив: ");
            for (int i = 0; i < num; i++) // Вывод результирующего массива
                Console.Write(Math.Round(mass[i],2) + " ");
        }
    }
}
