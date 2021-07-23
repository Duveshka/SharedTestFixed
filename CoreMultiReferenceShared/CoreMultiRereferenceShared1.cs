// lilia.shamsutdinova

namespace CoreMultiReferenceShared
{
    public class CoreMultiRereferenceShared1
    {
#if NETFRAMEWORK
        public string A = "A";
#endif
#if !NETFRAMEWORK
public string A = "AAA";
#endif

        public string AB = "A";
        private void Test34()
        {
            A = "";
        }
    }
}