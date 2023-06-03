
using System.Threading.Tasks;

namespace snff.bl.metal;

public class World : IWorld, IThink
{

    public World()
    {

    }

    T IWorld.AddEntity<T>(T entity)
    {
        throw new System.NotImplementedException();
    }

    T IWorld.GetEntity<T>(int id)
    {
        throw new System.NotImplementedException();
    }

    T IWorld.RemoveEntity<T>(T entity)
    {
        throw new System.NotImplementedException();
    }

    Task<IThink.IResult> IThink.Think()
    {
        throw new System.NotImplementedException();
    }
}