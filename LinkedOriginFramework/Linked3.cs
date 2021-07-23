#region test

using System;

#endregion

namespace OldIssues2017_3_1.NewFolder1.NewFolder1.SomeFolder.NewFolder1.BestFolder111
{
    public sealed class A123 // Alt+Enter -> Make static class on `class`
    {
        private static int Q = 1;

        private A123()
        {
        }

        public static void F()
        {
        }

        private class X : IDisposable
        {
            public void Dispose()
            {
            }
        }
    }
}