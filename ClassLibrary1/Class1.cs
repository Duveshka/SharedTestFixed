// lilia.shamsutdinova

#region test

using System;

#endregion

namespace FrameworkReferenceShared
{
    public class Class12
    {
        private void Test(int number, UserService serviceProvider)
        {
            var t = 1;
            using var request = new Request();

            request.Add();
            
            static void Test2(int other)
            {
                Console.WriteLine(other);
            }
        }
    }

    internal class Request : IDisposable
    {
        private void Test()
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            var s = "";

            var s2 = "";
        }

        public void Dispose()
        {
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    internal class UserService
    {
    }


    internal class Info
    {
        private string Id { get; set; }
        private string Name { get; set; }

        public Info Merge(string name, string id)
        {
            return new Info
            {
                Id = id + this.Id,
                Name = name + this.Name
            };
        }
    }
}