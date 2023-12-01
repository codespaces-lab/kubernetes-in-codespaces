namespace snff.bl.well

using System;

public class Pyrimid : IEntity<Pyrimid>
{
    public IContext Context { get; set; }

    public Pyrimid()
    {
    }

    public Task<IContext> Think(IContext context)
    {
        if (interval[TimeSpan.FromHours(1)])
        {
            
        }
    }
}
