#region test

using ReferencedMultipleShared;

#endregion

namespace CoreMultiReferenceShared
{
    public class Class3 : Class6
    {
        private void Test()
        {
            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
        }
    }

    public interface IPub
    {
        
    }

    public interface IPub2 : IPub
    {
        
    }

    public interface IPub3 : IPub
    {
        
    }

    public interface ISab
    {
        
    }

    public interface ISab2 : ISab
    {
        
    }
}