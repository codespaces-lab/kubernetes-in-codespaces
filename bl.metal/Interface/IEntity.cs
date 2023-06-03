namespace snff.bl.metal;

public interface IEntity<T>:IThing<T>, IThink<T>, IMove, IInteract, IAble, IOnAble, IAtAble
where T: new()
{



}
