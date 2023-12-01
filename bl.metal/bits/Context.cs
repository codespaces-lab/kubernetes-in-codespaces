using System;

namespace bl.metal
{
    public class Context: IContext
    {
        public Context()
        {
        }

        public dynamic this[string key] { get; set; }
        public dynamic Map { get; set; }

        public IContext Apply(string key, dynamic value)
        {
            throw new NotImplementedException();
        }

        public IContext Apply(dynamic map)
        {
            throw new NotImplementedException();
        }
    }
}