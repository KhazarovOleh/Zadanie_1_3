using System;
/*Даны два натуральных числа a и n, вычислить aaa... (n
слагаемых)*/

namespace Zadanie_1__3
{
    class Zadanie_1__3
    {
        static void Main(string[] args)
        {

            double sum = 0;
            Console.Write("Введите число и нажмите Enter: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество повторений и нажмите Enter: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                sum = Math.Sqrt(a + sum);
                sum = sum;
            }
            Console.WriteLine("\n" + "Значение суммы: " + sum);

        }
    }
}
