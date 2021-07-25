#region test

using System;
using NewFolder4;
using ReferencedMultipleShared;

#endregion

namespace CoreMultiReferenceShared
{
    public class Class5 : Class6
    {
        public void Test()
        {
            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
            var a = new A5();
            a.Test();
            MethodForTest(a);
        }

        public void MethodForTest (IInterface test)
        {
            test.Test();
        }
    }
}