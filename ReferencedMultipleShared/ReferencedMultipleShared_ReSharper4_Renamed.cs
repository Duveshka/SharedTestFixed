namespace ReferencedMultipleShared
{
    public class InClassName1
    {
        public InClassName1(InClassName inClassName)
        {
            InClassName = inClassName;
        }

        public InClassName InClassName { get; }
    }

    public class ReferencedMultipleShared_ReSharper4_Renamed
    {
        public void Method1()
        {
            var s = "";
        }

        public void Method2(InClassName1 inClassName1)
        {
        }
    }
}