namespace snff.bl.metal;

using System.Threading.Tasks;


public interface IThink
{
    Task<IThink.IResult> Think();

    public interface IResult
    {
        object MetricsForProm {get;set;}
        int timeTaked {get;set;}
    }



}



public interface IThunk
{
    Task<IThink.IResult> Thunk();

    public interface IResult
    {
        
    }



}



