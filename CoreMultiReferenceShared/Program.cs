#region test

using System;

using NewFolder4;
using ReferencedMultipleShared;
using Class12 = FrameworkReferenceShared.Class12;

#endregion

namespace CoreMultiReferenceShared
{
    internal class Program
    {
        private static int _parameter2;

        public Program(int parameter2)
        {
            _parameter2 = parameter2;
        }


        private static void Main(string[] args)
        {
            //var shared11 = new Shared11();
            //shared11.Method1();

            //var sharedVs2 = new SharedVS2(1);
            //sharedVs2.Method1123();


            //var multiShared1 = new MultiShared1();
            //multiShared1.Method2();
            var a = new Class5();
            a.Test();

            var b = new Class12();
            b.Test2();

            var c = new Testik();
            c.Test2();

            var part1 = new Partial1();
            var part2 = new Partial1();
            part1.Inter1();
            part2.Inter();
            part2.Test();

            var class4 = new Class4();
            class4.Test();

            var ReferencedMultipleSharedVs1 = new ReferencedMultipleShared_VS1();
            ReferencedMultipleSharedVs1.Method2(1);

            ReferencedMultipleSharedVs1.Name2_Renamed = "Jane Doe";

            var moveStaticMethod1 = ReferencedMultipleShared_VS1.MoveStaticMethod1(1);

            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
            var reSharper2 = new ReferencedMultipleShared_ReSharper2();
            var reSharper2_1 = new ReferencedMultipleShared_ReSharper2();
            var reSharper4 = new ReferencedMultipleShared_ReSharper4_Renamed();
            reSharper4.Method2(null);
            reSharper4.Method1();
            
        }
    }
}