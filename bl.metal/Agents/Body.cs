using System.Collections.Generic;
using System.Threading.Tasks;
using Openmetrics;

namespace snff.bl.metal;

public class Body : IEntity<Body>
{

    public dynamic Context { get; set; }

    public IThink<Body> Next => null;

    public IThink<Body> Previous { get; set; }

    public Body();

    public Task<IContext> Think(IContext context, IConfiguration config)
    {

    }

    IContext add_body_nodes(IContext context)
    {
        context.Map.body.members = new
        {
            neck = new
            {
                size = "current",
                style = "any",
            },
            chest = new
            {
                size = "current",
                style = "any",
            },
            midsection = new
            {
                size = "current",
                style = "any",
            },
            waist = new
            {
                size = "current",
                style = "any",
            },
            arms = new
            {
                size = "current",
                style = "any",
            },
            wrists = new
            {
                size = "current",
                style = "any",
            },
            hips = new
            {
                size = "current",
                style = "any",
            },
            legs = new
            {
                size = "current",
                style = "any",
            },
            ankles = new
            {
                size = "current",
                style = "any",
            },


        };

    }

    void the_clothes_make_the_man(IContext context, IConfiguration config)
    {
        //temporary fitting while versace algo is being developed
        context.Map.body.clothes = new
        {
            shirt = new
            {
                color = "any",
                size = "current",
                style = "any",
                fitting_nodes = new
                {
                    neck = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0
                    },
                    chest = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0
                    },
                    waist = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0                    },
                    arms = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0
                    },
                    wrists = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0
                    }
                }
            },
            pants = new
            {
                color = "any",
                size = "current",
                style = "any",3
                offset = 0,
                fitting_nodes = new
                {
                    waist = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0,
                        offset = new Matrix3()
                        { 
                            0, 0, 0,
                            0, 1, 0,
                            0, 0, 0
 
                        }

                    },
                    hips = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0
                    },
                    legs = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0
                    },
                    ankles = new
                    {
                        size = "current",
                        style = "any",
                        offset = 0
                    }
                }
            },
            belt = new
            {
                color = "any",
                size = "current",
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
