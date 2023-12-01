
using System.Threading.Tasks;

namespace snff.bl.metal

public class World : IWorld, IThink<T>, IThing<T>
{
    HashSet<IThink<T>> _thinks = new HashSet<IThink<T>>();
    HashSet<Thing<T>> _things = new HashSet<IThing<T>>();

    public HashSet<Thing<T>> Things { get => _things; set => _things = value; }
    public HashSet<IThink<T>> Thinks { get => _thinks; set => _thinks = value; }

    public World()
    {

    }

    T IWorld.AddThing<T>()
      where T : new()
    {
        var thing = new T();
        Things.Add(thing);
        return thing;
    }

    T IWorld.AddThing<T>(T thing)
    {
        Things.Add(thing);
        return thing;
    }

    T IWorld.GetThing<T>(int id)
    {
        return Things.FirstOrDefault(t => t.id == id);
    }

    T IWorld.RemoveThing<T>(T thing)
    {
        Things.Remove(thing);
    }

    T IWorld.AddThink<T>()
      where T : new()
    {
        var think = new T();
        Thinks.Add(think);
        return think;
    }

    T IWorld.AddThink<T>(T think)
    {
        Thinks.Add(think);
        return think;
    }

    T IWorld.GetThink<T>(int id)
    {
        return Thinks.FirstOrDefault(t => t.id == id);
    }

    T IWorld.RemoveThink<T>(T think)
    {
        Thinks.Remove(think);
    }
}

