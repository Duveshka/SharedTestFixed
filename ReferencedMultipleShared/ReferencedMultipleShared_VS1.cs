#region test

using System;

#endregion

namespace ReferencedMultipleShared
{
    internal class ReferencedMultipleShared_VS1 : ReferencedMultipleShared_VS1Base1,
        IReferencedMultipleShared_VS1
    {
        private string intToParse;

        public void Method3()
        {
            var s = string.Format("", 2, 3);
            var format = "";
            throw new NotImplementedException();
        }

        public void Method4()
        {
            throw new NotImplementedException();
        }

        public void Method5()
        {
            throw new NotImplementedException();
        }

        public void Method6()
        {
            throw new NotImplementedException();
        }

        public static string MoveStaticMethod1(int i)
        {
            return string.Empty;
        }

        public string ToString1(string A, string B, string C)
        {
            var a = ReferencedMultipleShared_Enum1.B;
            var success = int.TryParse(intToParse, out var integer);
            if (success)
                Console.WriteLine($"Success: {integer}");
            return base.ToString();
        }
    }
}