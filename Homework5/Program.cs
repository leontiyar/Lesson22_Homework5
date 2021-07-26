using System;
//Вывод 4 треугольников
namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры треугольников :");
            bool smart = int.TryParse(Console.ReadLine(), out int size);
            if (smart && size > 1)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 1; i <= size; i++)//Проходим по строкам от 1 до 10
                {
                    for (int j = 1; j <= i; j++)//Проходим по символам строки от 1 до і
                    {
                        Console.Write("#");//Отрисовываем #
                    }
                    Console.WriteLine();//В конце переходим на новую строку
                }
                Console.WriteLine();//Делаем отступ
                Console.WriteLine();
                for (int i = 1; i <= size; i++)//Снова проходимся по строкам
                {
                    for (int j = size; j >= i; j--)//Сейчас же запускаем обратный цикл,
                    //т.к. количество # убывает от 10 до 1
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 1; i <= size; i++)
                {
                    //В этот раз запускаем 2 последовательных цикла
                    for (int j = 1; j <= size - i; j++)//1 отрисовывает пробелы (количество пробелов на 1 строке - 9)
                    //,на 2 строке - 8 и на каждой 10-i
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)//а 2 - #(а количество решеток = 10 - (10 - i) = 10 - 10 + i = i)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 1; i <= size; i++)
                {
                    for (int j = size - 1; j > size - i; j--)//здесь к-ство пробелов увеличивается
                    {
                        Console.Write(" ");
                    }
                    for (int j = size; j >= i; j--)
                    {
                        Console.Write("#");//а к-ство # уменьшается
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Нужно вводить числа, которые больше 1!");
            }
        }
    }
}
