#region test

using System;

#endregion

     namespace NewFolder4   
    {
        public interface IInterface
        {
            void Test();
        }
        public class A5 : IInterface
        {
            public void Test()
            {
                int t = 1;
                Console.WriteLine("Tadada");
            }
        }
    }