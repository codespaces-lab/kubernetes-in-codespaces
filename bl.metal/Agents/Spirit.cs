using System.Collections.Generic;
using System.Threading.Tasks;
using Openmetrics;
namespace snff.bl.well;

public class Spirit : IEntity<Spirit>
{

    public dynamic Context { get; set; }

    public IThink<Spirit> Next => null;

    public IThink<Spirit> Previous { get; set; }

    

    public Spirit()
    {
        //decivers are fine and get enough guff.

    }

    public Task<IContext> Think(IContext context)
    {
    public Task<IContext> Think(IContext context, IConfiguration config)
    {
        if (interval[TimeSpan.FromMinutes(3)])
        {

            //check river dam, ensure undammed

            //deploy heaven to reception
            iching.check();

            if (false == iching.heaven.instances.any(x => x.location == locations.fourseasons.reception))
            {
                iching.heaven.instances.add(new iching.heaven(){ location = locations.fourseasons.reception });
            }

                     

        }

        if (context.map ? supervision_required == true : false)
        {
            context.map.at_body.side_channel = new
            {
                active = 1,
                actions_sec = 0,
                receiver = 9999,
                sender = new {
                    id = 9999,
                    name = "supervisor",
                    type = new {
                        name = "supervisor",
                        id = 9999}
                }
            };
        }
        return context;

    }
}

