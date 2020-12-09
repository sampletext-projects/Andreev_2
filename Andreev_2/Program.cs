using System;

namespace Andreev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от языка системы дробные числа с точкой не конвертируются из строк
            //поэтому точки вручную заменяем на запятые
            //.Replace(".", ",")

            Console.WriteLine("Введите a: ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите b: ");
            double b = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите c: ");
            double c = double.Parse(Console.ReadLine().Replace(".", ","));

            double x;
            if (a > b)
            {
                x = c;
            }
            else
            {
                x = a;
            }

            double y;
            if (x <= 0)
            {
                y = -Math.Log(-x);
            }
            else
            {
                y = Math.Log(x);
            }

            Console.WriteLine("y = " + y);
        }
    }
}
