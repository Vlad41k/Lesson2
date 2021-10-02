using System;

namespace Exercise._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1; // переменная для подсчета различных елементов 
            var rand = new Random();
            var num = rand.Next(5, 10);
            var mass = new int[num]; // Создание массива размерностью от 5 до 10 ячеек
            for (int i = 0; i < num; i++) // Заполнение массива
                mass[i] = rand.Next(1, 15);
            Console.Write("Исходный массив: ");
            for (int i = 0; i < num; i++) // Вывод исходного массива
                Console.Write(mass[i] + " ");
            Array.Sort(mass); // Сортировка массива
            for (int i = 0; i < num - 1; i++) // Сравнивание елментов массива
                if (mass[i] != mass[i + 1])
                    count++; // Подсччет различных елементов массива
            Console.Write("\nМассив содержит " + count + " различных елементов");
        }
    }
}
