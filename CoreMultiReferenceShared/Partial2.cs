using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMultiReferenceShared
{
    public partial class Partial1 : Interface1
    {
        public void Inter()
        {
            Console.WriteLine("Partial");
        }
        public void Test()
        {
            var a = new Partial1();
            MethodForTest(a);
        }

        public void MethodForTest(Interface1 test)
        {
            test.Inter();
        }
    }

}
