namespace snff.bl.metal;

using System.Threading.Tasks;
using Openmetrics;

public interface IThink<T>
{

    Task<dynamic> Think(dynamic context);

    IThink<T> Next { get;  }
    IThink<T> Previous { get; set; }

}



