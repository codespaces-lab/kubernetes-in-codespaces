using System.Collections.Generic;
using System.Threading.Tasks;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using snff.bl.well;
using System.Linq;


namespace snff.bl.services;

[ApiController]
[Route("[controller]")]
public class SpiritController : ControllerBase
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
        return await _think.Think();
    }
}

