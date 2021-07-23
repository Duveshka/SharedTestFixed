// lilia.shamsutdinova

using System;
using System.Collections.Generic;

namespace LinkedOriginFramework
{
    public class Linked2
    {
        private int _unknown;
        public string Name { get; set; }
        public void Method1()
        {
            int t = 12345;
            Console.WriteLine(t);
        }

        public string S { get; set; }
        public string Renamed_newProp { get; set; }

        protected virtual int I => _unknown;

        public string Method1(string s_parameter)
        {
            throw new System.NotImplementedException();
        }

        public static int Test11(IEnumerable<object> sequence)
        {
            int sum = 0;
            foreach (var i in sequence)
            {
                switch (i)
                {
                    case int n when n is var test/*inline here*/:
                        sum += test;
                        break;
                    default:
                        throw new InvalidOperationException("Unrecognized type");
                }
            }
            return sum;
        }

        int A()
        {
            int i = 0;
            try
            {
                i = new Random().Next();
                System.Threading.Thread.AllocateNamedDataSlot(i.ToString());
            }
            finally
            {
                bool b = GetBool();
                if (b == true)
                {
                    
                }
            }

            return i;
        }

        private bool GetBool()
        {
            throw new NotImplementedException();
        }
    }
}