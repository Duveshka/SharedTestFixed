namespace SharedProject22
{
    public class ReSharper1
    {


        public void Method1()
        {
        }

        public void Method2(string s)
        {
            throw new System.NotImplementedException();
        }

        public void Method3(string s, string s1)
        {
            Method2(s);
            Method2(s1);
            throw new System.NotImplementedException();
        }
    }
}