namespace snff.bl.metal;

using System;

public interface IFactory<T>
{
    public static IAgentEntity<T> New<T>() 
    {
        return null;
    }
    public static IAgentEntity<T> New(IWorld world) 
    {
        return null;
    }

}