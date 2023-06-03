
using System.Threading.Tasks;

namespace snff.bl.metal;

public class World : IWorld, IThink<T>
{

    public World()
    {

    }

    T IWorld.AddThing<T>()
      where T: new()
    {
        var thing = new T();
    }

    T IWorld.AddThing<T>(T thing)
    {
        throw new System.NotImplementedException();
    }

    T IWorld.GetThing<T>(int id)
    {
        throw new System.NotImplementedException();
    }

    T IWorld.RemoveThing<T>(T Thing)
    {
        throw new System.NotImplementedException();
    }
}