using System.Collections.Generic;

public interface IContext
{
    public dynamic this[string key] { get; set; }
    public dynamic Map { get; set; }


    public IContext With(this IContext context, string key)
    {

    }

    public IContext Apply(this IContext context, Dictionary<string, dynamic> map)
    {

    }






}