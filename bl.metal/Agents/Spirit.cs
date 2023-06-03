using System.Collections.Generic;
using System.Threading.Tasks;
using Openmetrics;
namespace snff.bl.metal;

public class Spirit : IEntity<Spirit>
{

    public dynamic Context { get; set; }

    public IThink<Spirit> Next => null;

    public IThink<Spirit> Previous { get; set; }

    public Spirit()
    {

    }

    public Task<dynamic> Think(dynamic context)
    {

        if (context.supervision_required == true)
        {
            context.at_body.side_channel{
                active,
                actions_sec,
                receiver

            };
            context.at_body.side_channel.active = 1;
            context.at_body.side_channel.actions_sec = 0;
            context.at_body.side_channel.receiver = 9999;
            
            
            context.at_body.side_channel.tags.
        }


        return context;
    }
}

