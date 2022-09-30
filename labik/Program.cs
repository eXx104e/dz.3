using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №4.1");
            Console.WriteLine("Введите любое число от 1 до 365");
            DateTime data = Convert.ToDateTime("01.01.2022");
            int number = Convert.ToInt32(Console.ReadLine());
            data = data.AddDays(number - 1);
            Console.WriteLine(data.ToString("Дата: d MMMM"));
            Console.Clear();

            Console.WriteLine("Задание №4.2");
            Console.WriteLine("Введите любой день от 1 до 365");
            DateTime data_ = Convert.ToDateTime("01.01.2022");
            int number_ = Convert.ToInt32(Console.ReadLine());
            if (number_ < 1 || number_ > 365)
                Console.WriteLine("1-365!");
            else
            {
                data_ = data_.AddDays(number_ - 1);
                Console.WriteLine(data_.ToString("Дата: d MMMM"));
            }
            Console.Clear();

            Console.WriteLine("Домашняя работа задание 4.1");
            Console.WriteLine("Введите любой день от 1 до 365 ");
            int hhh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            DateTime data1 = Convert.ToDateTime("01.01.2022");
            if (hhh < 1 || hhh > 365)
            {
                Console.WriteLine("Такого дня не существует");
            }
            else
            {
                data1 = data1.AddDays(hhh - 1);
                Console.WriteLine(data1.ToString("Дата: d MMMM"));
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"{year} год високосный ");
            }
            else
            {
                Console.WriteLine($"{year} год не високосный ");
            }
            Console.Clear();
        }
    }
}