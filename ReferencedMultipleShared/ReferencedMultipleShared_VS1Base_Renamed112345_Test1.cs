#region test

using System;
using System.Collections.Generic;
using ReferencedMultipleShared_1;

#endregion

namespace ReferencedMultipleShared
{
    internal class ReferencedMultipleShared_VS1Base_Renamed112345_Test12
    {
        public string Name1 { get; set; }
        public string Name2_Renamed { get; set; }

        public void Method1()
        {
            Method2(1);
        }

        public void Method2(int parameter212)
        {
            foreach (var s in new List<string>()) Console.WriteLine(s);

            NewMethod();
        }

        private static void NewMethod()
        {
            var shape = new Shape();
            shape.Method1("");
            var reSharper4 = new ReferencedMultipleShared_ReSharper4_Renamed();
            reSharper4.Method2(new InClassName1(InClassName.CreateInstance(null)));
        }
    }
}