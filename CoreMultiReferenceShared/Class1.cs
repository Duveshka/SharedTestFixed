#region test

using System;
using ReferencedMultipleShared;

#endregion

namespace CoreMultiReferenceShared
{
    public class Class1
    {
        private void Test()
        {
            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
            reSharper1.Method1();
        }
    }
}


namespace ReferencedMultipleShared
{
    public class Use11
    {
        public string S { get; set; }

        public string S1 { get; set; }

        public string S2 { get; set; }

        public string S3 { get; set; }

        private void t()
        {
            var referencedMultipleSharedReSharper1Renamed = new ReferencedMultipleShared_ReSharper1_Renamed();
            referencedMultipleSharedReSharper1Renamed.Method1();
            referencedMultipleSharedReSharper1Renamed.Method1();

            var tt = 123;
            Console.WriteLine(tt);

            // aaaaaaaaaaaaaaa
        }
    }
}