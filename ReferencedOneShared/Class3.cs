namespace CoreMultiReferencedSharedOne
{
    public class Class3
    {
    }

    class Info
    {
        private string Id { get; set; }
        string Name { get; set; }

        public Info Merge(string name, string id)
        {
            string s = "null";
            return new Info
            {
                Id = id + Id,
                Name = name + Name
            };
        }
    }
}