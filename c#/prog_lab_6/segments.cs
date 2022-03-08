using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class segments
    {
        private const int MAX = 100;
        private int n;
        private line[] ptrline = new line[MAX];
        public void vvod()
        {
            Console.Write($"Введите количество отрезков от 1 до {MAX}: ");
            while ((!int.TryParse(Console.ReadLine(), out n))||(n>MAX)||(n<1))
                Console.WriteLine("Количество отрезков введено неверно.");
            for(int i = 0; i < n; i++)
            {
                ptrline[i] = new line();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите координаты точек начала и конца отрезка {i}.");
                ptrline[i].vvod();
            }
        }
        public void totalvivod()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Отрезок {i}: ");
                ptrline[i].vivod();
                Console.WriteLine();
            }
        }
        public double totallength()
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += ptrline[i].length();
            }
            return sum;
        }
    }
}
