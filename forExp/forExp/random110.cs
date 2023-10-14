using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random110
{
    class Program
    {
        public string massiv1()
        {
            string[] look010;
            look010 = new string[] {"1,2,3,4,5,6,7,8,9"};
            return look010[GetRandomNumber(1)];
        }
        //задаём тип System.Random - он нужен для генерации случайных чисел.
        private Random r = new Random();
        //задаём метод и создаём массив с числами от 0 до 10.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
        public string ChislaOt0Do10()
        {
            string[] chisla = new string[] {"Ноль", "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять", "Десять" };
            return chisla[GetRandomNumber(11)];
        }

        //из книги: "Частная вспомогательная функция для получения случайного числа"
        private int GetRandomNumber(short upperLimit)
        {
            //также из книги: "Random.Next() возвращает случайное целочисленное число в диапазоне
            //между 0 и upperLimit".
            return r.Next(upperLimit);
        }

        public static void Main(string[] args)
        {
            Program mike = new Program();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("При нажатии клавиши \"Пробел\" отобразится рандомное число от 0 до 10.");
                Console.WriteLine("Также при нажатии на любую другую клавишу вы покините консольное приложение.\n");
                Console.Write("Рандомное число от 0 до 10:");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.Write(mike.ChislaOt0Do10() + ".\n\n");
                    Console.Write("Нажмите любую клавишу чтобы выйти..."); 
                    Console.ReadKey();
                } 
            }
        }
    }
}