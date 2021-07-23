#region test

using CoreMultiReferenceShared;
using ReferencedMultipleShared;

#endregion

namespace FrameworkReferenceShared
{
    public class FrameworkReferenceShared1
    {
        public FrameworkReferenceShared1()
        {
            var shared11 = new Shared11();
            shared11.Method1();

            var sharedVs2 = new SharedVS2(1);

            sharedVs2.Method123();

            var multiShared1 = new MultiShared1();

            multiShared1.Method3();

            var ReferencedMultipleSharedVs1 = new ReferencedMultipleShared_VS1();
            new ReferencedMultipleShared_VS1().Method2(1);
            var moveStaticMethod1 = ReferencedMultipleShared_VS1.MoveStaticMethod1(1);

            var reSharper4 = new ReferencedMultipleShared_ReSharper4_Renamed();

            reSharper4.Method2(new InClassName1(InClassName.CreateInstance(null)));
        }
    }
}