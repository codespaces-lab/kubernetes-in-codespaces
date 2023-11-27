namespace snff.bl.well;

public interface IEntity<T>:IInterval, IThing<T>, IThink<T>, IMove, IInteract, IAble, IOnAble, IAtAble
where T: new()
{
    

    



}
