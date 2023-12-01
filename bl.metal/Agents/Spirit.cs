using System.Collections.Generic;
using System.Threading.Tasks;
using Openmetrics;
namespace snff.bl.metal

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
                    type = ne
                        name = "supervisor",
                        id = 9999}
                }
            };
        }
        return context;


    }

    public void Goto(Piece p)
    {
        
        var p =  World.Path(p.location);
        move(p); 
        
    }

    public void abate_attack(Piece[] involved ) {
        
        this.InterruptStatus.Push("Abating attack")
            
        if (this.pieces.body.is_fighting) {
            this.Goto(this.pieces.body);
            var t = (Piece)this.pieces.body.query(Query.Target);
            t.engage().follow(3.5); 
            // soul moves to location looks target
            this.actions.look(this.pieces.soul);
            await this.pieces.body.query(Query.Disengage)
            t.disengage();
        }
        this.InterruptStatus.Pop();

    }
}

