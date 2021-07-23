namespace CoreMultiReferenceShared.NewFolder
{
    public class ReferencedMultipleShared_ReSharper5
    {
        public string Name { get; set; }

        public void Method1()
        {
            Name = "Jane Doe";
        }

        public string Method2()
        {
            return Name;
        }
    }

    internal class AnotherCreatedClass
    {
        public AnotherCreatedClass(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            ;
        }
    }
}