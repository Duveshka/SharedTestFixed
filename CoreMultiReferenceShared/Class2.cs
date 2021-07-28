#region test

using ReferencedMultipleShared;

#endregion

namespace CoreMultiReferenceShared
{
    public class Class2
    {
        private void Test()
        {
            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
            for (int i = 0; i < 1000; i++)
            {
                break;
            }

            int n = 1;
            int cost = 0;
            switch (n)
            {
                case 1:
                    cost += 25;
                    break;
                case 2:
                    cost -= 25;
                    goto case 1;
                case 3:
                    cost += 50;
                    goto case 1;
                default:
                    break;
            }
        }
    }
}