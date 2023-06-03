

using System;

namespace snff.bl.metal
{
    public interface IWorld
    {
        T AddEntity<T>(T entity);
        T GetEntity<T>(int id);
        T RemoveEntity<T>(T entity);

    }
}