using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MainClass
    {
        /// <summary>
        /// Период Пизано - длина периода последовательности Фибоначчи по модулю заданного числа n.
        /// </summary>
        /// <param name="m"> Делитель </param>
        /// <param name="n"> Порядковый номер числа Фиббоначчи</param>
        /// <returns></returns>
        private static List<long> getPisanoPeriod(long m, long n)
        {
            List<long> mas = new List<long>();
            if (m == 1)
            {
                mas.Add(0);
                return mas;
            }
            long second = 0;
            long first = 1;
            mas.Add(second);
            mas.Add(first);
            bool isZero = false; //the first is not considered
            for (long i = 0; i < 6 * m + 2; i++)
            {
                long tmp = first;
                first = (first + second) % m;
                second = tmp;
                if (!isZero)
                {
                    if (first == 0)
                    {
                        isZero = true;
                    }
                    else
                    {
                        mas.Add(first);
                    }

                }
                else
                {
                    if (first == 1)
                    {
                        return mas;
                    }
                    else
                    {
                        isZero = false;
                        mas.Add(second);
                        mas.Add(first);
                    }
                }
            }
            return mas;
        }

        public static void Main()
        {

            string[] s = Console.ReadLine().Split();
            long n = long.Parse(s[0]);
            long m = long.Parse(s[1]);
            List<long> pisanoPeriod = getPisanoPeriod(m, n);
            long i = n % pisanoPeriod.Count;
            Console.WriteLine(pisanoPeriod[Convert.ToInt32(i)]);

        }
    }
}