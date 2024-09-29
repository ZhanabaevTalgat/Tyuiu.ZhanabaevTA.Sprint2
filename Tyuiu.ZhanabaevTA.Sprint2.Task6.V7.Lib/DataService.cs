using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhanabaevTA.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            string MonthName = n switch
            {
                0 => "Январь",
                1 => "Февраль",
                2 => "Март",
                3 => "Апрель",
                4 => "Май",
                5 => "Июнь",
                6 => "Июль",
                7 => "Август",
                8 => "Сентябрь",
                9 => "Октябрь",
                10 => "Ноябрь",
                11 => "Декабрь",
                _ => "Неизвестный месяц" // Обработка неверного ввода
            };

            return MonthName;
        }
    }
}
