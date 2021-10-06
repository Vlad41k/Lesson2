using System;
//НЕ РЕШЕНО
namespace Exercise._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountRow, CountCol; // Переменные для созданиея результирующего массива
            var rand = new Random();
            var num = rand.Next(4, 5);
            CountCol = CountRow = num;
            int[,] mass = new int[num,num]; // Создание матрицы размерностью от 3 до 5 ячеек
            for (int i = 0; i < num; i++) // Заполнение матрицы
                for (int j = 0; j < num; j++)
                    mass[i, j] = rand.Next(-1, 1);
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < num; i++) // Вывод исходной матрицы
            {
                for (int j = 0; j < num; j++)
                    Console.Write(mass[i, j] + "\t");
                Console.Write("\n");
            }
            for (int i = 0; i < num; i++) // Цикл для перестановки нулевых столбцов вправо
            {
                int TempCol = 0; // Переменная для счетчика
                int temp; // Переменная для перестановки елементов
                for (int j = 0; j < CountCol; j++)
                {
                    if (mass[j, i] == 0) // Проверка на равенство нулю элемента столбца
                        TempCol++; // Инкрементирование счетчика
                }
                if (TempCol == num) // Проверка на равенство нулю всех элементов столбца
                {
                    if (i < CountCol - 1) // Рассмотрение всех столбцов кроме крайнего правого
                        for (int z = i; z < CountCol-1; z++)
                        for (int j = 0; j < num; j++) // Перестановка нулевого столбца вправо
                        {
                            temp = mass[j, z];
                            mass[j, z] = mass[j, z + 1];
                            mass[j, z + 1] = temp;
                        }
                    CountCol--; // Дикриментирование кол-ва столбцов результирующей матрицы
                }
            }
            Console.WriteLine("Результующий массив: ");
            for (int i = 0; i < num; i++) // Вывод Результующей матрицы
            {
                for (int j = 0; j < num; j++)
                    Console.Write(mass[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }
}
