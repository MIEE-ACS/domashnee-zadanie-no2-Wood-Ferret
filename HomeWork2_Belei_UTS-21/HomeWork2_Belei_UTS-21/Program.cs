using System;
using System.Globalization;

namespace hw2
{
    class Programm
    {
        static double Segment1(double x)
        {
            int k = 0;
            int b = -3;
            double y = k * x + b;
            return y;
        }
        static double Segment2(double x)
        {
            double k = 0.6;
            double b = 1.8;
            double y = k * x + b;
            return y;
        }
        static double Segment3(double x, double r)
        {
            double y = Math.Sqrt(r * r - x * x);
            return y;
        }
        static double Segment4(double x)
        {
            int k = 1;
            int b = -3;
            double y = k * x + b;
            return y;
        }
        static double Segment5(double x)
        {
            int k = 0;
            int b = 3;
            double y = k * x + b;
            return y;
        }

        static int Main(string[] args)
        {
            int A = 1;
            do
            {
                Console.WriteLine("Введите радиус(r)");
                int r;
                string R;
                do
                {
                    R = Console.ReadLine();
                    if (int.TryParse(R, out r))
                    {
                        break;
                    }
                    Console.WriteLine("Радиус должен быть целым числом.");
                } while (true);
                if (r < 0)
                {
                    Console.WriteLine("Радиус не может быть отрицательным, уверен, что это вы не специально, поэтому переведу в положительное число)");
                    r = -1 * r;
                    Console.WriteLine($"Радиус(r) = {r}");
                }
                if (r == 0)
                {
                    Console.WriteLine("Радиус не может быть равен 0, возьму ближайшее, т.е 1");
                    r = 1;
                }
                if (r < 3)
                {
                    Console.WriteLine("Функция будет не определена в некоторых точках");
                }
                for (double x = -10; x <= 8.1; x = x + 0.2)
                {
                    if ((x >= -10) && (x <= -8))
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                    }
                    else if ((x > -8) && (x <= -2.9))
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x));
                    }
                    if ((x >= -3) && (x <= 3))
                    {
                        if (r < 3)
                        {
                            Console.WriteLine($"Фунция не определена от -3 до {-r} и от {r} до 3");
                            for (double i = -r; i <= r; i += 0.2)
                            {
                                Console.WriteLine("y({0:0.00}) = {1:0.00}", i, Segment3(i, r));
                            }
                            x = 3;
                        }
                        if (r > 3)
                        {
                            for (double i = -3; i <= 3.1; i += 0.2)
                            {
                                Console.WriteLine("y({0:0.00}) = {1:0.00}", i, Segment3(i, r));
                            }
                            x = 3;
                        }
                        if ((r == 3) && (x > -3.1))
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x, r));
                        }
                    }
                    if ((x >= 3) && (x <= 5))
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                    }
                    if (((x >= 5) && (x <= 8.1)))
                    {

                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment5(x));
                    }
                }
                Console.WriteLine("Хотите повторить? 1 - да; 0 - нет");
                A = Convert.ToInt32(Console.ReadLine());
            } while (A == 1);
            return 0;
        }
    }
}
