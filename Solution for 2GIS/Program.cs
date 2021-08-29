using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_for_2GIS
{
    // Класс уравнение
    public class equation
    {
        public int N = 3;
        public float[] mas;

        public float InsertDates(int i)
        {
            float a = 0, b = 0, c = 0;
            switch (i)
            {
                case 0:
                    {
                        Console.WriteLine("Введите первый(A) коофициент: ");
                        a = float.Parse(Console.ReadLine());
                        return a;
                    }
                case 1:
                    {
                        Console.WriteLine("Введите второй(B) коофициент: ");
                        b = float.Parse(Console.ReadLine());
                        return b;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите третий(С) коофициент: ");
                        c = float.Parse(Console.ReadLine());
                        return c;
                    }
                default: throw new ArgumentException("Недопустимый код операции");
            }
        }
        public void WriteDates(float a, float b, float c)
        {
            Console.WriteLine("Получилось следующиее уравнение: \n");
            Console.WriteLine(a + "X^2 + " + b + "X + " + c + " = 0");
            Console.WriteLine("====================================\n");
        }
        public void Solution(float a, float b, float c)
        {
            float d = 0;
            double x1 = 0, x2 = 0;
            d = b * b - 4 * a * c;
            Console.WriteLine("Дискриминант: " + d);
            if (d > 0)
            {
                Console.WriteLine("Так как дискриминант больше нуля, то решение в вещественных числах.");
                x1 = ((-1) * b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("\t X1 = " + x1);
                x2 = ((-1) * b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("\t X2 = " + x2);
            }
            if (d < 0)
            {
                double x1_1 = 0, x2_1 = 0;
                Console.WriteLine("Так как дискриминант меньше нуля, то решение в не вещественных числах.");
                d = -d;
                x1 = (-1) * b / (2 * a);
                x1_1 = Math.Sqrt(d) / (2 * a);
                Console.WriteLine("\t X1 = " + x1 + " + " + x1_1 + "i");
                x2 = (-1) * b / (2 * a);
                x2_1 = Math.Sqrt(d) / (2 * a);
                Console.WriteLine("\t X1 = " + x1 + " - " + x1_1 + "i");
            }
            if (d == 0)
            {
                Console.WriteLine("Так как дискриминант равен нулю, то решение в вещественных числах и оба корня совпадут по значению.");
                x1 = ((-1) * b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("\t X1 = " + x1);
                Console.WriteLine("\t X2 = " + x1);
            }
            return;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int N = 3;
            float[] mas = new float[N];
            equation first = new equation();
            Console.WriteLine("Ввод коофициентов\n");
            for (int i = 0; i < 3; i++)
            {
                mas[i] = first.InsertDates(i);
            }
            Console.WriteLine("====================================");
            first.WriteDates(mas[0], mas[1], mas[2]);
            Console.WriteLine("====================================");
            Console.WriteLine("Решение: ");
            first.Solution(mas[0], mas[1], mas[2]);
            Console.WriteLine("====================================");
            Console.ReadKey();
        }
    }
}
