
using System.Threading.Tasks;

namespace snff.bl.metal;

public class World : IWorld, IThink
{
    public int AddEntity<T>(IAgentEntity<T> agent) 
    {
        return 0;
    }

    Task<IThink.IResult> IThink.Think()
    {
        throw new System.NotImplementedException();
    }
}