using System;
//Вывод 4 треугольников
namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)//Проходим по строкам от 1 до 10
            {
                for (int j = 1; j <= i; j++)//Проходим по символам строки от 1 до і
                {
                    Console.Write("#");//Отрисовываем #
                }
                Console.WriteLine();//В конце переходим на новую строку
            }
            Console.WriteLine();//Делаем отступ
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)//Снова проходимся по строкам
            {
                for (int j = 10; j >= i; j--)//Сейчас же запускаем обратный цикл,
                //т.к. количество # убывает от 10 до 1
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                //В этот раз запускаем 2 последовательных цикла
                for (int j = 1; j <= 10-i; j++)//1 отрисовывает пробелы (количество пробелов на 1 строке - 9)
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
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 9; j > 10-i; j--)//здесь к-ство пробелов увеличивается
                {
                    Console.Write(" ");
                }
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("#");//а к-ство # уменьшается
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
