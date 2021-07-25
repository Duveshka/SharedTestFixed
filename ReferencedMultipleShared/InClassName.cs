using System.Threading.Tasks;

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

    public class Location
    {
        private string locationName;

        public Location(string name) => Name = name;

        public string Name
        {
            get => locationName;
            set 
                => locationName = value;
        }

        public async Task<Location> Name2 ()
        {
            Location i = null;
            return i;
        }
    }
}