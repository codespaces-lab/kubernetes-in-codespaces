

using System;

namespace snff.bl.well
{
    public interface IWorld
    {
        HashSet<IThink<T>> Thinks { get; set; }
        HashSet<IThing<T>> Things { get; set; }
        T AddThing<T>();
        T AddThing<T>(T thing);
        T GetThing<T>(int id);
        T RemoveThing<T>(T Thing);

        T AddThink<T>();
        T AddThink<T>(T thing);
        T GetThink<T>(int id);
        T RemoveThink<T>(T Thing);


    }
}