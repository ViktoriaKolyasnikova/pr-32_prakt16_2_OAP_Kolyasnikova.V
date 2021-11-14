using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt16_2_OAP_Kolyasnikova.V
{
    class S
    {
        public double z, x;
        public S Sum(S a, S b)
        {
            S res = new S();
            res.z = a.z + b.z;
            res.x = a.x + b.x;
            return res;
        }

        public S Multiplication(S a, S b)
        {
            S res = new S();
            res.z = a.z * b.z;
            res.x = a.x * b.x;
            return res;
        }

        public S Subtract(S a, S b)
        {
            S res = new S();
            res.z = a.z - b.z;
            res.x = a.x - b.x;
            return res;
        }

        public void Print(S a)
        {
            Console.Write("{0} + i{1}", a.z, a.x);
        }

        public void PrintLine(S a)
        {
            Console.WriteLine("{0} + i{1}", a.z, a.x);
        }
    }

    class Program
    {

    static void Main(string[] args)
        {
            Console.Write("Введите целую часть первого комплексного числа: ");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            double z2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            S s1 = new S();
            S s2 = new S();
            s1.z = z1;
            s1.x = x1;
            s2.z = z2;
            s2.x = x2;
            Console.WriteLine("Комплексные числа: ");
            s1.PrintLine(s1);
            s2.PrintLine(s2);
            Console.WriteLine("\nДля продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Сложение: {0} + {1}i", s1.Sum(s1, s2).z, s1.Sum(s1, s2).x);
            Console.WriteLine("Умножение: {0} + {1}i", s1.Multiplication(s1, s2).z, s1.Multiplication(s1, s2).x);
            Console.WriteLine("Вычитание: {0} + {1}i", s1.Subtract(s1, s2).z, s1.Subtract(s1, s2).x);
            Console.WriteLine("\nДля выхода нажмите Enter");
            Console.ReadLine();
        }
    } 
}
