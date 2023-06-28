using System.Collections.Generic;
using System.Dynamic;

public class AgentContext : IContext
{
    private dynamic _map;

    public dynamic this[string key] { get => _map[key]; set => _map[key] = value; }
    public dynamic Map { get => _map; set => _map = value; }

    public AgentContext()
    {
        _map = new ExpandoObject();
    }

    public IContext With( string key)
    {
        return this.Map[key];
    }

    public IContext Apply(dynamic context, Dictionary<string, dynamic> map)
    {
        foreach (var item in map)
        {
            this[item.Key] = item.Value;
        }

        return this;
    }
}



