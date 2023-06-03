namespace snff.bl.metal;
using System.Threading.Tasks;


public interface IThunk<T>
{
    Task<IThunk<T>.IResolver> Thunk();

    public interface IResolver
    {
        
    }
}
