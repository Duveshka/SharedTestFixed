using System;
using LinkedOriginCore;
using LinkedOriginFramework;

namespace LinkedDestinationCore
{
    class Program
    {

        static void Main(string[] args)
        {
            new Linked8().Method4(1);
            var linked1 = new Linked1();
            linked1.Method1();
            var method2 = linked1.Method2_1();
            Console.WriteLine("Hello World!");

            new Linked2();

            var linked10 = new Linked10();
            linked10.Method1();
        }
    }
}
