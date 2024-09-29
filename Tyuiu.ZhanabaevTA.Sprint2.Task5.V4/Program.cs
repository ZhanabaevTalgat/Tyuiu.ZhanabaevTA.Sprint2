using Tyuiu.ZhanabaevTA.Sprint2.Task5.V4.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Оператор switch                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти           *");
            Console.WriteLine("* «червы» — 4. По заданному номеру масти m (1 <= m <= 4) определить       *");
            Console.WriteLine("* название соответствующей масти.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер масти: ");
            int NumberSuit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            if (NumberSuit >= 1 && NumberSuit <= 4)
            {
                string Suit = ds.FindCardSuit(NumberSuit);
                Console.WriteLine("Это масть: " + Suit);
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }

            Console.ReadKey();
        }
    }
}
