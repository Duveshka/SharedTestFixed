#region test

using System;

#endregion

namespace CoreMultiReferenceShared
{
    public class Shared11
    {
        public string Name { get; set; }
#if NETCOREAPP
        public void Method1(string s)
        {
            Console.WriteLine(s);
        }
#endif
        public void Method1()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}