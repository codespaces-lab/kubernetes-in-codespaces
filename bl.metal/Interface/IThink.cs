namespace snff.bl.metal

using System.Threading.Tasks;
using Openmetrics;

public interface IThink<T>:IThing<T> 
{

    Task<dynamic> Think(IContext context);

    IThink<T> Next { get;  }
    IThink<T> Previous { get; set; }

}



