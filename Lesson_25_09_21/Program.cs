using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    enum Week { понедельник = 1, вторник, среда, четверг, пятница, суббота, воскресенье}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите трехзначное число");
            int num = Convert.ToInt32(Console.ReadLine());
            int hun = num / 100;
            int doz = (num / 10) % 10;
            int unit = num % 10;
            if (hun == doz & hun == unit & doz == unit)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else if (hun == unit)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите длину форточки");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширну форточки");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите диметр головы");
            double d = Convert.ToDouble(Console.ReadLine());
            double gap_1 = (a - d) / 2, gap_2 = (b - d) / 2;
            if (gap_1 >= 1 & gap_2 >= 1)
            {
                Console.WriteLine("Вася сможет высунуть голову");
            }
            else
            {
                Console.WriteLine("Вася не сможет высунуть голову");
            }

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите номер дня недели");
            int num_week = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Week)num_week);

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите номер карты");
            int num_card = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (num_card)
                {
                    case 6:
                        Console.WriteLine("шестерка");
                        break;
                    case 7:
                        Console.WriteLine("семерка");
                        break;
                    case 8:
                        Console.WriteLine("восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("девятка");
                        break;
                    case 10:
                        Console.WriteLine("десятка");
                        break;
                    case 11:
                        Console.WriteLine("валет");
                        break;
                    case 12:
                        Console.WriteLine("дама");
                        break;
                    case 13:
                        Console.WriteLine("король");
                        break;
                    case 14:
                        Console.WriteLine("туз");
                        break;
                    default:
                        Console.WriteLine("Не существует такой карты");
                        break;
                };
            }
            catch(FormatException)
            {
                Console.WriteLine("Вы ввели не тот формат");
            }

            Console.WriteLine("Задание 5");
            int radius = 6370;
            for (short h = 1; h <= 10; h++)
            {
                double dis = Math.Sqrt(2 * radius * h);
                Console.WriteLine("При высоте {0} км расстояние до линии горизонта: {1}", h, dis);
            }

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите число от 1 до 9");
            short n = Convert.ToInt16(Console.ReadLine());
            for (short i = 1; i <= 9; i++)
            {
                int result = n * i;
                Console.WriteLine("{0} * {1} = {2}", i, n, result);
            }

            Console.WriteLine("Задание 7");
            int count = 0, sum = 0, number = 0;
            try
            {
                while (number >= 0)
                {
                    Console.WriteLine("Введите целое число");
                    number = Convert.ToInt32(Console.ReadLine());
                    sum += number;
                    count++;
                }
                double sr_znach = sum - number;
                count--;
                sr_znach /= count;
                Console.WriteLine("Среднее арифметическое чисел = {0}", sr_znach);
            }
            catch(FormatException)
            {
                Console.WriteLine("Вы ввели не тот формат");
            }

            Console.WriteLine("Задание 8");
            int past_num, position = 0;
            count = 1;
            Console.WriteLine("Введите число");
            number = Convert.ToInt32(Console.ReadLine());
            past_num = number;
            while (count < 10)
            {
                if (past_num > number)
                {
                    position = count;
                    break;
                }
                past_num = number;
                count++;
                number = Convert.ToInt32(Console.ReadLine());
            }
            if (count == 10)
            {
                Console.WriteLine("Последовательность является возрастающей");
            }
            else
            {
                Console.WriteLine("Последовательность не является возрастающей");
                Console.WriteLine("Порядковый номер числа = {0}", position);
            }

            Console.WriteLine("Задание 9");
            sum = 0; number = 1;
            int j = 0;
            Console.WriteLine("Введите целое число");
            while (number != 0)
            {
                number = Convert.ToInt32(Console.ReadLine());
                j++;
                if (j % 3 != 0)
                    continue;
                sum += number;
            }
            Console.WriteLine("Сумма = {0}", sum);

            Console.WriteLine("Задание 10");
            double summa = 0, num_1 = 0;
            Console.WriteLine("Введите число");
            Сycle:
            num_1 = Convert.ToDouble(Console.ReadLine());
            if (num_1 != 0)
            {
                summa += num_1;
                goto Сycle;
            }
            Console.WriteLine("Сумма = {0}", summa);
            
            Console.ReadKey();
        }
    }
}
