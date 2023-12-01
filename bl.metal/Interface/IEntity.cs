namespace snff.bl.metal

public interface IEntity<T>:IInterval, IThing<T>, IThink<T>, IMove, IInteract, IAble, IOnAble, IAtAble
where T: new()
{
    

    



}
