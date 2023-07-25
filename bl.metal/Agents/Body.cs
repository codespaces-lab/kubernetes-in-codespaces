using System.Collections.Generic;
using System.Threading.Tasks;
using Openmetrics;

namespace snff.bl.metal;

public class Body : IEntity<Body>
{

    public dynamic Context { get; set; }

    public IThink<Body> Next => null;

    public IThink<Body> Previous { get; set; }

    Interval interval = new Interval();

    public Body();

    public Task<IContext> Think(IContext context, IConfiguration config)
    {
        if (interval[TimeSpan.FromMinutes(3)])
        {
            iching.check();

            if (false == iching.heaven.instances.any(x => x.location == locations.fourseasons.reception))
            {
                iching.heaven.instances.add(new iching.heaven(){ location = locations.fourseasons.reception });
            }
        }
    }
}

void use_body_nodes(IContext context)
{   
    context.Map.body.fibunit = 3.51;
    context.Map.body.members = new
    { 
        neck = new
        {
            size = "accumulated",
            style = "leaning_dainty",
            offsets_from_center = new
            {
                1,1,1, //
                1,1,1, //
                1,1,1, //
            }
        },
        chest = new
        {
            size = "accumulated",
            style = "toned_not_ripped",
            offset_from_center = new
            {
                3,5,3, //this row is better
                5,1,5, //than this row
                3,2,3  // and stuf
            }
        },
        midsection = new
        {
            size = "accumulated",
            style = "not_belly_pot",
            offset_from_center = new
            {
                2,3,2, //this row is better
                5,1,5, //than this row
                2,2,2  //and stuf
            }
        },
        waist = new
        {
            size = "accumulated", 
            style = "not_muffin_top",
            offset_from_center = new
            {
                3,3,3, //this row is better
                5,1,5, //than this row
                3,2,3  //and stuf
            }
            },
        arms = new
        {
            size = "accumulated",
            style = "any",
        },
        wrists = new
        {
            size = "accumulated",
            style = "any",
        },
        hips = new
        {
            size = "accumulated",
            style = "any",
        },
        legs = new
        {
            size = "accumulated",
            style = "any",
        },
        ankles = new
        {
            size = "accumulated",
            style = "any",
        },
    };
}

public IContex add_clothes_make_the_man(IContext context, IConfiguration config )
{
    //temporary fitting while versace algo is being developed
    context.Map.body.clothes = new
    {
        shirt = new
        {
            color = "any",
            size = "accumulated",
            style = "any",
            fitting_nodes = new
            {
                neck = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                },
                chest = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                },
                waist = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                },
                arms = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                },
                wrists = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                }
            }
        },
        pants = new
        {
            color = "any",
            size = "accumulated",
            style = "any",
            offset = .5,
            fitting_nodes = new
            {
                waist = new
                {
                    size = "accumulated",
                    style = "any",
                    //idenity 2,2 == 1,1 1,2 1,3 == front
                    offset = new
                    {
                        0.5,
                        0.5,
                        0.5,
                        0.5,
                        1.0,
                        0.5,
                        0.5,
                        0.75,
                        0.5
                    }
                },
                hips = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                },
                legs = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                },
                ankles = new
                {
                    size = "accumulated",
                    style = "any",
                    offset = 0
                }
            }
        },
        belt = new
        {
            color = "any",
            size = "accumulated",
            style = "any",
            fitting_nodes = new
            {
                waist = new
                {
                    size = "bind",
                    offset = .5,
                    style = "any",
                },
            }
        }
    };

    foreach (var item in context.Map.body.clothes)
    {
        foreach (var node in Body.members)
        {

        }
    }
}
}
