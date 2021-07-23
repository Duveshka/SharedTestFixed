#region test

using CoreMultiReferenceShared.NewFolder;

#endregion

namespace ReferencedMultipleShared
{
    public class ExtractClassOwnFileUndoDisabled
    {
        public void Method2(InClassName1 inClassName1)
        {
            var method2 = new ReferencedMultipleShared_ReSharper5().Method2();
        }
    }
}