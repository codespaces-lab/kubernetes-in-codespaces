using System.Threading.Tasks;

namespace snff.bl.metal;

public class Spirit : IAgentEntity<Spirit>, IFactory<Spirit>
{

    public IAgentEntity<Spirit> New()
    {
        return new Spirit();
    }
0
    public IAgentEntity<Spirit> New(IWorld world)
    {
        var z = new Spirit();
        world.AddEntity(z);
        return z;
    }

    Task<IThink.IResult> IThink.Think()
    {
        throw new System.NotImplementedException();
    }

    protected Spirit()
    {

    }

}
