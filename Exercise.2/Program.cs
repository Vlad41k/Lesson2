using System;

namespace Exercise._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartTime = 480; // начало учебного дня
            int lessonDuration = 45; // продолжительность урока
            int BreakDuration = 10; // длительность обычной еремены
            int BigBreakDuration = 20; // длительность большой еремены
            int NumberOfLessons = 6; // количетсво уроков
            int BigBreakPosition = 3; // место большого перерыва
            Console.Write(StartTime / 60 + ":" + StartTime % 60 + " - ");  // Вывод начала учебных занятий
            for (int i = 0; i < NumberOfLessons; i++)
            {
                StartTime += lessonDuration;// Добавление времени урока к общему времени занятий
                Console.WriteLine(StartTime / 60 + ":" + StartTime % 60);
                if (i != NumberOfLessons - 1)
                    if (i != BigBreakPosition) // Регулирование обычных и большиъ перемен
                    {

                        StartTime += BreakDuration; // Добавление времени обычной перемены к общему времени занятий
                        Console.Write(StartTime / 60 + ":" + StartTime % 60 + " - ");
                    }
                    else
                    {
                        StartTime += BigBreakDuration; // Добавление времени большой перемены к общему времени занятий
                        Console.Write(StartTime / 60 + ":" + StartTime % 60 + " - ");
                    }
            }

        }
    }
}
