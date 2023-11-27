using System.Collections.Generic;
using System.Collections.Specialized;

namespace snff.bl.well;

public interface IThing<T> : IFactory<T>
    where T : new()
{   
 
    
    public Guid  Id { get; set; }
    public string Name => "";
}

