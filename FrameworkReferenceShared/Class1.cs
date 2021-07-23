#region test

using System;
using ReferencedMultipleShared;

#endregion

namespace FrameworkReferenceShared
{
    public class Class12
    {

        public void Test2()
        {
            var a = new Request();
            MethodForTest(a);
        }

        public void MethodForTest(IDisposable test)
        {
            test.Dispose();
        }
        private void Test(int number, UserService serviceProvider)
        {
            using var request = new Request();

            request.Add();

            static void Test2(int other)
            {
                Console.WriteLine(other);
            }

            serviceProvider.GetRequiredService();

            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
        }
    }

    internal class Request : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("netadada");
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    internal class UserService
    {
    }
}