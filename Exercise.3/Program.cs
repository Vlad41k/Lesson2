using System;
//НЕ РЕШЕНО
namespace Exercise._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var num = rand.Next(3, 5);
            int[,] mass = new int[num,num]; // Создание матрицы размерностью от 3 до 5 ячеек
            for (int i = 0; i < num; i++) // Заполнение матрицы
                for (int j = 0; j < num; j++)
                    mass[i, j] = rand.Next(-1, 2);
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < num; i++) // Вывод исходной матрицы
            {
                for (int j = 0; j < num; j++)
                    Console.Write(mass[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }
}
