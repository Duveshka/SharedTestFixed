#region test

using System;
using System.Threading;

#endregion

namespace LinkedOriginFramework
{
    //class Shape
    //{
    //    private Point pivot;

    //    private void LogDrawing(Logger logger)
    //    {
    //        var msg = $"Shape is drawn at {pivot.X}, {pivot.Y}";

    //    }

    //    //public string S { get; set; }

    //}


    internal class Logger1
    {
        private LocalDataStoreSlot _allocateNamedDataSlot;

        private X x;
        public string S { get; set; }

        private int A()
        {
            // type some comment

            // type something else


            // type else

            var s = 12345;
            Console.WriteLine(s);


            var i = 0;
            try
            {
                i = new Random().Next();
                _allocateNamedDataSlot = Thread.AllocateNamedDataSlot(i.ToString());
            }
            finally
            {
                // selection start
                Thread.FreeNamedDataSlot(i.ToString());
                // selection end
            }

            return i;
        }

        private void Te(Exception e)
        {
            switch (x)
            {
                case X.A:
                    return;
                case X.B:
                    break;
                case X.C:
                    break;
                default:
                    throw e;
            }
        }

        public static bool SomeMethod()
        {
            if (SomeMethodReturningAnInt() == 0) return true;

            return false;
        }

        private static int SomeMethodReturningAnInt()
        {
            throw new NotImplementedException();
        }

        public void SomeLog(string msg)
        {
            var confirmed = true;
            var data = confirmed
                ? new {confirmed}
                : new
                {
                    confirmed = false
                };
            var a = 0;
            var a_ = 0; // produces "Inconsistent naming" warning
            // log the message

            var t = 1234;
            Console.WriteLine(t);


            // ohohoho ssssss
        }

        private enum X
        {
            A,
            B,
            C
        }
    }

    public class Linked1
    {
        public string S { get; set; }
        public string Name { get; set; }

        public void Method1()
        {
        }

        // test


        public string Method2_1()
        {
            return Name;
        }

        public void Method3_Renamed()
        {
            throw new NotImplementedException();
        }

        public void Method4(int i)
        {
        }

        public void Method5(int i)
        {
            throw new NotImplementedException();
        }

        private void Test_New()
        {
            // comment new renamed
        }


        public void Method6(int i)
        {
            throw new NotImplementedException();
        }

        public void Method7(int i)
        {
            throw new NotImplementedException();
        }

        public string Method8(int i)
        {
            throw new NotImplementedException();
        }

        public void Method9(int i)
        {
            throw new NotImplementedException();
        }

        public void Method10(int i)
        {
            throw new NotImplementedException();
        }

        public void Method11(int i)
        {
            throw new NotImplementedException();
        }

        public void Method12(int i)
        {
            throw new NotImplementedException();
        }

        public void Method41_11(int i)
        {
            throw new NotImplementedException();
        }

        private class MyClass
        {
            //comment
        }


        private class Foo_1
        {
            public int IntValue { get; set; }
        }

        private class Use
        {
            private readonly Foo_1 _foo1;

            public Use(Foo_1 foo1)
            {
                _foo1 = foo1;
                Action<int> setterAction = v => foo1.IntValue = v;
            }

            public void AddRange<T>(params T[] items)
            {
            }


            public void Foo()
            {
                //Refactoring "Remove 'params' array creation" deletes all comments
                //Initial code:
                AddRange("Item1", "Item2", "Item3");

                //Result after refactoring:
                AddRange("Item1",
                    "Item2",
                    "Item3");

                //Expected result after refactoring:
                AddRange("Item1", //Comment1
                    "Item2", //Comment2
                    "Item3"); //Comment3
            }

            private void Setter(int value)
            {
                _foo1.IntValue = value;
            }
        }

        public static class Test
        {
            private static void Main1()
            {
                int renamed;
                Foo(out renamed);
                Console.WriteLine(renamed);
            }

            public static void Foo(out int smth)
            {
                smth = 12;
            }
        }
    }
}