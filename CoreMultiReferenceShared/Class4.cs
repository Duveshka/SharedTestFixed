#region test

using ReferencedMultipleShared;

#endregion

namespace CoreMultiReferenceShared
{
    public class Class4 : Class1
    {
        private void Test()
        {
            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
        }
    }
}