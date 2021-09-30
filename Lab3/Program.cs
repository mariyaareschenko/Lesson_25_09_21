using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    enum MonthName { January=1, February, March, April, May, June, July, August, September, October, November, December }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.1");
            Console.WriteLine("Введите номер дня от 1 до 365");
            int num_day = Convert.ToInt32(Console.ReadLine()), num_month = 1;
            if (num_day <= 31) //январь
            {
                goto End;
            }
            else
            {
                num_day -= 31;
                num_month++;
            }
            if (num_day <= 28) //февраль
            {
                goto End;
            }
            else
            {
                num_day -= 28;
                num_month++;
            }
            if (num_day <= 31) //март
            {
                goto End;
            }
            else
            {
                num_day -= 31;
                num_month++;
            }
            if (num_day <= 30) //апрель
            {
                goto End;
            }
            else
            {
                num_day -= 30;
                num_month++;
            }
            if (num_day <= 31) //май
            {
                goto End;
            }
            else
            {
                num_day -= 31;
                num_month++;
            }
            if (num_day <= 30) //июнь
            {
                goto End;
            }
            else
            {
                num_day -= 30;
                num_month++;
            }
            if (num_day <= 31) //июль
            {
                goto End;
            }
            else
            {
                num_day -= 31;
                num_month++;
            }
            if (num_day <= 31) //август
            {
                goto End;
            }
            else
            {
                num_day -= 31;
                num_month++;
            }
            if (num_day <= 30) //сентябрь
            {
                goto End;
            }
            else
            {
                num_day -= 30;
                num_month++;
            }
            if (num_day <= 31) //октябрь
            {
                goto End;
            }
            else
            {
                num_day -= 31;
                num_month++;
            }
            if (num_day <= 30) //ноябрь
            {
                goto End;
            }
            else
            {
                num_day -= 30;
                num_month++;
            }
            if (num_day <= 31) //декабрь
            {
                goto End;
            }
            else
            {
                num_day -= 31;
                num_month++;
            }
        End:
            MonthName mounth = (MonthName)num_month;
            string name_month = mounth.ToString();
            Console.WriteLine("{0} {1}", num_day, name_month);

            Console.WriteLine("Задание 4.2");
            try
            {
                Console.WriteLine("Введите номер дня от 1 до 365");
                num_day = Convert.ToInt32(Console.ReadLine()); num_month = 1;
                if (num_day < 1 || num_day > 365)
                {
                    throw new ArgumentOutOfRangeException("Неверно введен номер дня");
                }
                if (num_day <= 31) //январь
                {
                    goto End;
                }
                else
                {
                    num_day -= 31;
                    num_month++;
                }
                if (num_day <= 28) //февраль
                {
                    goto End;
                }
                else
                {
                    num_day -= 28;
                    num_month++;
                }
                if (num_day <= 31) //март
                {
                    goto End;
                }
                else
                {
                    num_day -= 31;
                    num_month++;
                }
                if (num_day <= 30) //апрель
                {
                    goto End;
                }
                else
                {
                    num_day -= 30;
                    num_month++;
                }
                if (num_day <= 31) //май
                {
                    goto End;
                }
                else
                {
                    num_day -= 31;
                    num_month++;
                }
                if (num_day <= 30) //июнь
                {
                    goto End;
                }
                else
                {
                    num_day -= 30;
                    num_month++;
                }
                if (num_day <= 31) //июль
                {
                    goto End;
                }
                else
                {
                    num_day -= 31;
                    num_month++;
                }
                if (num_day <= 31) //август
                {
                    goto End;
                }
                else
                {
                    num_day -= 31;
                    num_month++;
                }
                if (num_day <= 30) //сентябрь
                {
                    goto End;
                }
                else
                {
                    num_day -= 30;
                    num_month++;
                }
                if (num_day <= 31) //октябрь
                {
                    goto End;
                }
                else
                {
                    num_day -= 31;
                    num_month++;
                }
                if (num_day <= 30) //ноябрь
                {
                    goto End;
                }
                else
                {
                    num_day -= 30;
                    num_month++;
                }
                if (num_day <= 31) //декабрь
                {
                    goto End;
                }
                else
                {
                    num_day -= 31;
                    num_month++;
                }
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }

            Console.WriteLine("Домашнее задание 4.1");
            try
            {
                Console.WriteLine("Введите год");
                int num_year = Convert.ToInt32(Console.ReadLine());
                bool leap_year = ((num_year % 4 == 0) && (num_year % 100 != 0 || num_year % 400 == 0));
                int max_day = leap_year ? 366 : 365;
                Console.WriteLine("Введите номер дня от 1 до 365");
                num_day = Convert.ToInt32(Console.ReadLine()); num_month = 1;
                if (num_day < 1 || num_day > 365)
                {
                    throw new ArgumentOutOfRangeException("Неверно введен номер дня");
                }
                if (leap_year)
                {
                    if (num_day <= 31) //январь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 29) //февраль
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 29;
                        num_month++;
                    }
                    if (num_day <= 31) //март
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //апрель
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //май
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //июнь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //июль
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 31) //август
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //сентябрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //октябрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //ноябрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //декабрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                }
                else
                {
                    if (num_day <= 31) //январь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 28) //февраль
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 28;
                        num_month++;
                    }
                    if (num_day <= 31) //март
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //апрель
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //май
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //июнь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //июль
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 31) //август
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //сентябрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //октябрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                    if (num_day <= 30) //ноябрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 30;
                        num_month++;
                    }
                    if (num_day <= 31) //декабрь
                    {
                        goto End;
                    }
                    else
                    {
                        num_day -= 31;
                        num_month++;
                    }
                }
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
            Console.ReadKey();
        }
    }
}
