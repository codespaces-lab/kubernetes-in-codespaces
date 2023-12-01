namespace snff.bl.well
{
    public class Interval
    {


        public Interval() => intervals = new Dictionary<Timesapne, DateTime>();

        public bool this[string timespan]
        {
            get
            {
                if (false == intervals.TryGetValue(timespan, out DateTime last)
                    || true == last + timespan <= DateTime.Now)
                {
                    intervals[timespan] = DateTime.Now + timespan;
                    return true;

                } 
                else 
                {
                    return false;
                }
            }
            set
            {
                intervals[timespan] = DateTime.Now + timespan;
                return true;
            }
        }

        public dynamic update()
        {
            return this;
        }
    }
}