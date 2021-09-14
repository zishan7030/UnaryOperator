using System;

namespace UnaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b;
            Console.WriteLine("The original value is" + a);
            a++;
            Console.WriteLine("The First increamented value is" + a++);
            b = a++;
            Console.WriteLine("a:{0},b:{1}" ,a ,b);
            b += a;
            Console.WriteLine("a:{0},b:{1}", a, b);


        }
    }
}
