using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Program
    {
        enum Daysoftheweek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static int[] outsort(int[] skrrr)
        {
            int temp;
            for (int i = 0; i < skrrr.Length; i++)
            {
                for (int j = i + 1; j < skrrr.Length; j++)
                {
                    if (skrrr[i] > skrrr[j])
                    {
                        temp = skrrr[i];
                        skrrr[i] = skrrr[j];
                        skrrr[j] = temp;
                    }
                }
            }
            return skrrr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            Console.WriteLine("Введите длину форточки");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину форточки");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите диаметр");
            double c = double.Parse(Console.ReadLine());
            if (a >= c + 2 && b >= c + 2)
            {
                Console.WriteLine("Пролезет");
            }
            else
            {
                Console.WriteLine("Не пролезет");
            }
            Console.Clear();

            Console.WriteLine("Задание №2");
            Console.WriteLine("Введите число от 1 до 9");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 9)
            {
                Console.WriteLine($"1*{n} = {n * 1}");
                Console.WriteLine($"2*{n} = {n * 2}");
                Console.WriteLine($"3*{n} = {n * 3}");
                Console.WriteLine($"4*{n} = {n * 4}");
                Console.WriteLine($"5*{n} = {n * 5}");
                Console.WriteLine($"6*{n} = {n * 6}");
                Console.WriteLine($"7*{n} = {n * 7}");
                Console.WriteLine($"8*{n} = {n * 8}");
                Console.WriteLine($"9*{n} = {n * 9}");
            }
            else
            {
                Console.WriteLine("ОТ 1 ДО 9!");
            }
            Console.Clear();

            Console.WriteLine("Задание №3");
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("BANG! BOOM!");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("BANG!");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("BOOM!");
            }
            else
            {
                Console.WriteLine("Мимо");
            }
            Console.Clear();

            Console.WriteLine("Задание №4");
            Console.WriteLine("Введите строку");
            string lul = Console.ReadLine();
            int tnt = 0;
            foreach (Char f in lul.ToCharArray())
            {
                if (Char.IsUpper(f))
                {
                    tnt++;
                }
            }
            if (tnt == lul.Length)
            {
                Console.WriteLine("Все буквы заглавные");
            }
            else
            {
                Console.WriteLine("Не все буквы заглавные");
            }
            Console.Clear();

            Console.WriteLine("Задание №5");
            Console.WriteLine("Введите целое положительное число");
            int sheep = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sheep; i++)
            {
                Console.Write(i + " овца... ");
            }
            Console.Clear();

            Console.WriteLine("Задание №6");
            Console.Write("Введите последовательность чисел");
            string z = Console.ReadLine();
            string[] z_ = z.Split(' ');
            int[] yngbrh = new int[z_.Length];
            for (int i = 0; i < yngbrh.Length; i++)
                yngbrh[i] = int.Parse(z_[i]);
            double summa = 0;
            try
            {
                for (int i = 0; i < (yngbrh.Length - 1); i++)
                    summa += yngbrh[i];
                double t = summa / (yngbrh.Length - 1);
                Console.WriteLine($"Среднее арифметическое равно {t}");
            }
            catch (Exception)
            {
                Console.WriteLine("Пожалуйста, введите последовательность корректно");
            }
            Console.Clear();

            Console.WriteLine("Задание №7");
            try
            {
                int card = Convert.ToInt32(Console.ReadLine());
                switch (card)
                {
                    case 6:
                        Console.WriteLine("Шестёрка");
                        break;
                    case 7:
                        Console.WriteLine("Семёрка");
                        break;
                    case 8:
                        Console.WriteLine("Восьмёрка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
            Console.Clear();

            Console.WriteLine("Задание №8");
            int dolls = 0;
            string[] bag = { "Winx", "Bratz", "Hello Kitty", "Monster High", "Something", "Barbie doll", "Чувааааак" };
            foreach (string s in bag)
            {
                if (s == "Hello Kitty" || s == "Barbie doll")
                {
                    dolls++;
                }
            }
            Console.WriteLine($"В сумке {dolls} куклы");
            Console.Clear();

            Console.WriteLine("Задание №9");
            Console.WriteLine("Какой по счету день недели? ");
            int days_ = int.Parse(Console.ReadLine());
            switch (days_)
            {
                case 1:
                    Console.WriteLine(Daysoftheweek.Понедельник);
                    break;
                case 2:
                    Console.WriteLine(Daysoftheweek.Вторник);
                    break;
                case 3:
                    Console.WriteLine(Daysoftheweek.Среда);
                    break;
                case 4:
                    Console.WriteLine(Daysoftheweek.Четверг);
                    break;
                case 5:
                    Console.WriteLine(Daysoftheweek.Пятница);
                    break;
                case 6:
                    Console.WriteLine(Daysoftheweek.Суббота);
                    break;
                case 7:
                    Console.WriteLine(Daysoftheweek.Воскресенье);
                    break;
            }
            Console.Clear();

            Console.WriteLine("Задание №11");
            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] skrrr = new int[N];
            for (int i = 0; i < skrrr.Length; i++)
            {
                skrrr[i] = Convert.ToInt32(Console.ReadLine());

            }
            outsort(skrrr);
            Console.Write("Сортировка 'пузырьком': ");
            for (int i = 0; i < skrrr.Length; i++)
            {
                Console.Write(skrrr[i] + " ");
            }
            Console.Write("| Сортировка с помощью внутренних методов: ");
            Array.Sort(skrrr);
            foreach (int I in skrrr)
                Console.Write(I + " ");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 11. Последовательность");
            int[] bubble = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int m = 0;
            for (int i = 0; i < bubble.Length; i++)
            {
                for (int j = 0; j < bubble.Length - 1 - i; j++)
                {
                    if (bubble[j] < bubble[j + 1])
                    {
                        m++;
                    }
                    else
                    {

                        Console.WriteLine($"Элемент {j + 2} нарушает упорядоченность последовательности");
                        break;
                    }
                    if (m + 1 == bubble.Length)
                    { Console.WriteLine("Последовательность упорядочена"); }
                }
                break;
            }
        }
    }
}