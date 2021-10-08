using System;
//НЕ РЕШЕНО
namespace Exercise._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "cba1076/abfc3785,3946f"; // Создание строки символов
            var words = text.Split('/', ',', '"'); // Распределение стркои в массив слов 
            for (int i = 0; i < words.Length; i++) // Проходка по всех словам в массиве
            {
                char[] charArray = words[i].ToCharArray(); // Распределения слова в массив символов
                Array.Sort(charArray); // Сортировка массива символов
                words[i] = ""; // Присваивание віходному слову пустого значения
                for (int z = 0; z < charArray.Length; z++) 
                    for (int j = 0; j < charArray.Length - 1; j++)
                        if ((Char.IsNumber(charArray[j]) == true) && (Char.IsNumber(charArray[j + 1]) == false)) // Перестановка цифр в правую сторону
                        {
                            char temp = charArray[j];
                            charArray[j] = charArray[j + 1];
                            charArray[j + 1] = temp;
                        }
                for (int z = 0; z < charArray.Length; z++)
                    for (int j = charArray.Length-1; j >0; j--)
                        if ((Char.IsNumber(charArray[j]) == true) && (Char.IsNumber(charArray[j - 1]) == true) && (charArray[j] > charArray[j - 1])) // Сортировка цифр по уменьшению
                        {
                            char temp = charArray[j];
                            charArray[j] = charArray[j - 1];
                            charArray[j - 1] = temp;
                        }
                for (int j = 0; j < charArray.Length; j++) // Заполнения слова отсортированными символами
                    words[i] += charArray[j];
            }
            foreach (var word in words) // Вывод массива слов на экран
            {
                Console.WriteLine("<" + $"{word}" + ">");
            }
        }
    }
}
