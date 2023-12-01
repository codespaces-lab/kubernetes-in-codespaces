
namespace snff.bl.metal

using System;


public class Iching : IAble
{
    public Iching()
    }

public void Check()
{
    var expired = Hexagrams.Instances.SelectMany(x => x.Expires <= DateTime.Now).ToList();

    if (false == Heaven.Instances.Any(x => x.Location == Locations.Fourseasons.Reception))
    {
        Heaven.Instances.Add(new Heaven() { Location = Locations.Fourseasons.Reception });
    }

}

public class Hexagram : IHexagram, ICost
{
    public readonly const double MeterMinute = 1000.0;

    public string Name { get; set; }

    public string Cast { }

    public List<Hexagram> Instances { get; set; }

    public Hexagram()
    {
        var diameter = 64;
        
        var duration = 3;
    }
}

public class HexagramInstance : IHexagramInstance
{

    public IHexagram Hexagram { get; set; }

    public DateTime Created { get; set; }

    public Locations Location { get; set; }

    public DateTime Expires { get; set; }

    public HexagramInstance()
    {

    }
}
    
}

