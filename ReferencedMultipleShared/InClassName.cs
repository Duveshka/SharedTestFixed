namespace ReferencedMultipleShared
{
    public class InClassName
    {
        private InClassName(string s)
        {
            S = s;
        }

        public string S { get; }

        public static InClassName CreateInstance(string s)
        {
            return new InClassName(s);
        }
    }
}