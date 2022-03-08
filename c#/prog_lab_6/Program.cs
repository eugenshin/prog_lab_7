using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class Program
    {
        static void outint(out int cord)//возврат out
        {
            Console.WriteLine($"Вызвана функция с параметром out. Переменной присвоено значение 0.");
            cord = 0;
        }
        static void refint(ref int cord)//возврат ref
        {
            Console.WriteLine($"Вызвана функция с параметром ref. Значение переменной не изменено.");
        }
        static void ptis5(point point)
        {
            point.X = point.Y = 5;
        }
        static void ptis5(ref pointstruct ptstr)
        {
            ptstr.x = ptstr.y = 5;
        }
        static void Main(string[] args)
        {
            point[] pt1 = new point[3];//массив объектов
            for(int i = 0; i < 3; i++)
            {
                pt1[i] = new point();
            }
            pt1[0].X = 1;
            pt1[0].Y = 2;
            pt1[1].X = 5;
            pt1[1].Y = 10;
            Console.Write($"Введите описание точки: ");
            pt1[0].Discription = Console.ReadLine();//работа со строками
            Console.WriteLine($"Описание точки: {pt1[0].Discription}");
            Console.Write($"Координаты точки 0: ");
            pt1[0].vivod();
            Console.Write($"\nКоординаты точки 1: ");
            pt1[1].vivod();
            Console.Write($"\nРезультат перегрузки оператора \"++\" для точки 0: ");
            pt1[0]++;
            pt1[0].vivod();
            Console.Write($"\nТочка 2 - результат перегрузки оператора \"+\" для точек 0 и 1: ");
            pt1[2] = pt1[0]+pt1[1];
            pt1[2].vivod();
            Console.WriteLine();
            outint(out int a);
            Console.WriteLine($"Значение a = {a}");
            refint(ref a);
            Console.WriteLine($"Значение a = {a}");
            pointstruct ptstr = new pointstruct();
            ptis5(ref ptstr);
            ptis5(pt1[0]);
            Console.WriteLine($"Значения класса pt1[0] были изменены x = {pt1[0].X}, y = {pt1[0].Y}");
            Console.WriteLine($"Структура ptstr была предана по ссылке с помощью параметра ref и её значения были изменены x = {ptstr.x}, y = {ptstr.y}\n");
            Console.ReadLine();
        }
    }
}