using Tyuiu.ZhanabaevTA.Sprint2.Task3.V21.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Вложенные операторы if - else                                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение       *");
            Console.WriteLine("* до трех знаков после запятой                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*        x * ( (x+9) / (x-1) )^2 , если x > 1                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*        (x^2 + 10) / (x^2 - sin(x^2) + 12) , если  x = 0                 *");
            Console.WriteLine("*  y =                                                                    *");
            Console.WriteLine("*        ( 1 + 1/x^2 )^x , если -25 < x < 2                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*        x + 10x - (1/x) , если x < -25                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double res = ds.Calculate(x);
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
