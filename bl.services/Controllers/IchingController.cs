namespace snff.bl.metal;
using System;
using Microsoft.AspNetCore.Mvc;

public class IChingController : ControllerBase
{
    public IChingController()
    {
    }

    [HttpGet]
    public async Task<dynamic> Get()
    {

    }

    public dynamic Load()
    {
        var json = File.ReadAllText("iching.json");
        var iching = JsonConvert.JObject(json);

    }



}
