
using System.Threading.Tasks;

namespace snff.bl.metal;

public class World : IWorld, IThink<T>, IThing<T>
{
    HashSet<IThink<T>> _thinks = new HashSet<IThink<T>>();
    HashSet<Thing<T>> _things = new HashSet<IThing<T>>();
    public World()
    {

    }

    T IWorld.AddThing<T>()
      where T : new()
    {
        var thing = new T();
        _things.Add(thing);
        return thing;
    }

    T IWorld.AddThing<T>(T thing)
    {
        _things.Add(thing);
        return thing;
    }

    T IWorld.GetThing<T>(int id)
    {
        return _things.FirstOrDefault(t => t.id == id);
    }

    T IWorld.RemoveThing<T>(T thing)
    {
        _things.Remove(thing);
    }

    T IWorld.AddThink<T>()
      where T : new()
    {
        var think = new T();
        _thinks.Add(think);
        return think;
    }

    T IWorld.AddThink<T>(T think)
    {
        _thinks.Add(think);
        return think;
    }

    T IWorld.GetThink<T>(int id)
    {
        return _thinks.FirstOrDefault(t => t.id == id);
    }

    T IWorld.RemoveThink<T>(T think)
    {
        _thinks.Remove(think);
    }
}

