using System.Collections.Generic;
using System.Threading.Tasks;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using snff.bl.metal;
using System.Linq;


namespace snff.bl.services;

[ApiController]
[Route("[controller]")]
public class SpiritController : ControllerBase, IThink
{
    static HashSet<IThink<Spirit>> _spirits = new HashSet<IThink<Spirit>>();


    IWorld _world;

    public SpiritController(IWorld world) : base()
    {
        _world = world;

    }

    [HttpGet]
    public async Task<dynamic> Get()
    {
        if (_world.Thinks.Count(tk => tk is IThink<Spirit>) == 0)
        {
            lock (_world)
            {
kjm              var qt = Config.SpiritCount;
                _spirits.AddRange(Enumerable.Range(0, qt).Select(i => new Spirit(i)));
                _world.Thinks.AddRange(_spirits);
            }

            return "Warmup";
        }
        else
        {
            await _spirits.Parallel.ForEach(s => s.Think(_world));
        }
    }
}

