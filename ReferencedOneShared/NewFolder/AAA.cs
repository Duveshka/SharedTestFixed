namespace CoreMultiReferencedSharedOne.NewFolder
{
    internal class AAA
    {
        public string S { get; set; }
        public string S1 { get; set; }

        private void Test()
        {
            var s1 = "112345";

            var s2 = "1234";
        }

        private static void NewMethod()
        {
            string s1 = "112345";

            string s2 = "1234";
        }
    }
}