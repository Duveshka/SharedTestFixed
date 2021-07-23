#region test

using System;
using System.Drawing;

#endregion

namespace ReferencedMultipleShared
{
    internal class ExtractedClass
    {
        public string S { get; set; }
    }

    internal class SharedVS2
    {
        private readonly ExtractedClass _extractedClass;

        public SharedVS2(int i)
        {
            // another comment

            new SharedVS2(1);
            Point tt;
            var t = 123;

            Console.WriteLine(t);
            A.Test(null);

            throw new NotImplementedException();
            _extractedClass = new ExtractedClass();
        }


        public string Name { get; set; }


        public string Method123()
        {
            throw new NotImplementedException();
        }


        public void Method1()
        {
        }

        public void Method1123()
        {
            throw new NotImplementedException();
        }
    }

    internal class A
    {
        public static void Test(string s)
        {
        }
    }
}