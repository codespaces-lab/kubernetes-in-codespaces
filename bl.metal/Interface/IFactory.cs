namespace snff.bl.metal

using System;
using System.Collections.Generic;

public interface IFactory<T> where T : new()
{
    public T New()
    {
        return new T();
    }

    public T New(IWorld world)
    {
        var neo = world.AddThing<T>(new T());

        return neo;
    }

    public List<T> New(IWorld world, long qty)
    {
        var list = new List<T>();

        for (int i = 0; i < qty; i++)
        {
            var neo = world.AddThing<T>(new T());
            list.Add(neo);
        }

        return list;
    }

}