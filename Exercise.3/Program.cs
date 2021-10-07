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
            CountCol = CountRow = num; // Переменные для хранения крличества строк и столбцов результирующей матрицы 
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
            for (int i = 0; i < num; i++) // Цикл для перестановки нулевых строк и столбцов
            {
                int TempCol = 0; // Переменная для счетчика
                int TempRow = 0; // Переменная для счетчика
                int temp; // Переменная для перестановки елементов
                for (int j = 0; j < CountCol; j++)
                    if (mass[j, i] == 0) // Проверка на равенство нулю элемента столбца
                        TempCol++; // Инкрементирование счетчика
                for (int j = 0; j < CountRow; j++)
                    if (mass[i, j] == 0) // Проверка на равенство нулю элемента строки
                        TempRow++; // Инкрементирование счетчика
                if (TempCol == num) // Проверка на равенство нулю всех элементов столбца
                {
                    if (i < CountCol - 1) // Рассмотрение всех столбцов кроме крайнего правого
                        for (int z = i; z < CountCol - 1; z++)  // Выполнение действия до понца столбцов
                            for (int j = 0; j < num; j++) // Перестановка нулевого столбца вправо
                            {
                                temp = mass[j, z];
                                mass[j, z] = mass[j, z + 1];
                                mass[j, z + 1] = temp;
                            }
                    CountCol--; // Дикриментирование кол-ва столбцов результирующей матрицы
                }
                if (TempRow == num) // Проверка на равенство нулю всех элементов строки
                {
                    if (i < CountRow - 1) // Рассмотрение всех столбцов кроме нижнего
                        for (int z = i; z < CountRow - 1; z++) // Выполнение действия до понца строк
                            for (int j = 0; j < num; j++) // Перестановка нулевой строки вниз
                            {
                                temp = mass[z, j];
                                mass[z, j] = mass[z + 1, j];
                                mass[z + 1, j] = temp;
                            }
                    CountRow--; // Дикриментирование кол-ва строк результирующей матрицы
                }
            }
                int[,] result = new int[CountRow, CountCol]; // Создание результирующей матрицы
                for (int i = 0; i < CountRow; i++) // заполнение результирующей матрицы
                    for (int j = 0; j < CountCol; j++)
                        result[i, j] = mass[i, j];
            Console.WriteLine("Результующий массив: ");
            for (int i = 0; i < CountRow; i++) // Вывод Результующей матрицы
            {
                for (int j = 0; j < CountCol; j++)
                    Console.Write(result[i, j] + "\t");
                Console.Write("\n");
            }
            for (int i = 0; i < CountRow; i++) // Проверка на положительное число
                for (int j = 0; j < CountCol; j++)
                    if (result[i, j] > 0)
                    {
                        Console.WriteLine("Первый положительный елемент находится в " + (i+1) + " строке");
                        return;
                    }
            Console.WriteLine("Массив не содержит положительных елементов");
        }
    }
}
