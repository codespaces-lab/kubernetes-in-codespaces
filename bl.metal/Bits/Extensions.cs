using System.Collections.Generic;
using System.Dynamic;

namespace snff.bl.metal;

public static class Ext
{
    public static void Set(this object context, Dictionary<string, dynamic> properties)
    {
        foreach (var pair in properties)   
        {
            context
            context[pair.Key] = pair.Value;
        }
    }
}