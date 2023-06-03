using System.Collections.Generic;
using System.Threading.Tasks;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using snff.bl.metal;


namespace snff.bl.services;

[ApiController]
[Route("[controller]")]
public class SpiritController : ControllerBase
{

    IThink _think;

    public SpiritController() 
    {
        
    } 

    [HttpGet]
    public async Task<object> Get(DaprClient daprClient)
    {
        return await _think.Think();
    }
}

