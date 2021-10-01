using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.1");
            Console.WriteLine("Введите вещественное число");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num < 0)
            {
                num = -num;
            }
            Console.WriteLine("Абсолютная величена = {0}", num);

            Console.WriteLine("Задание 1.2");
            Console.WriteLine("Введите первое число");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num1a = num1, num2a = num2;
            if (num1 < 0)
            {
                num1a = -num1;
            }
            if (num2 < 0)
            {
                num2a = -num2;
            }
            if (num1a > num2a)
            {
                num1 = num1 / 2;
            }
            Console.WriteLine("Результат: {0}", num1);

            Console.WriteLine("Задание 1.3");
            Console.WriteLine("С каким животным встретиалсь лягушка?");
            string animal = Console.ReadLine();
            string mouthSize = "wide";
            if (animal.ToLower() == "алигатор")
            {
                mouthSize = "small";
            }
            Console.WriteLine(mouthSize);

            Console.WriteLine("Задание 1.4");
            Console.WriteLine("Введите название напитка");
            string str = Console.ReadLine();
            string name_drinc = str.ToLower();
            try
            {
                switch (name_drinc)
                {
                    case "jabroni":
                        Console.WriteLine("Patron Tequila");
                        break;
                    case "school counselor":
                        Console.WriteLine("Anything with Alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "bike gand member ":
                        Console.WriteLine("Moonshine");
                        break;
                    case "politician":
                        Console.WriteLine("Your tax dollar");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                };
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Задание 1.5");
            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            string substring = "English";
            bool b = str.Contains(substring);
            if (b)
            {
                Console.WriteLine(b);
            }
            else
            {
                b = false;
                Console.WriteLine(b);
            }

            Console.WriteLine("Задание 2.1");
            double  a1 = 3, a2 = a1*a1, a3 = a2*a1, a4 = a2*a2, a5 = a3*a2, a6 = a3*a3, a7 = a5*a2, a8 = a4*a4;
            double numerator = 1 + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8;
            double denominator = a8;
            double result = numerator / denominator;
            Console.WriteLine("1 + 1/3 + 1/3^2 + ... + 1/3^8 = {0}", result);

            Console.WriteLine("Задание 2.2");

            Console.ReadKey();
        }
    }
}
