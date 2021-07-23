#region test

using System;
using ReferencedOneShared;
using ReferencedOneShared.NewFolder;

#endregion

namespace CoreMultiReferencedSharedOne
{
    internal class Program
    {
        private void Test()
        {
            var s1 = "";

            var s2 = "";
        }

        private static void Main(string[] args)
        {
            var reference = new ReferencedOneShared_VSCreatedBeforeReference1();
            reference.ReferencedOneSharer_VSCreatedBeforeReference_Name2 = "";
            reference.Method1();

            var method4 = new ReferencedOneShared_ReSharper3().Method4();

            var referencedOneSharedVs1 = new ReferencedOneShared_VS1();
            if (referencedOneSharedVs1 != null)
            {
                var referencedOneSharedReSharper4 = new ReferencedOneShared_ReSharper4();
                referencedOneSharedVs1.Field1 = true;
            }

            Console.WriteLine("Hello World!");
        }
    }
}