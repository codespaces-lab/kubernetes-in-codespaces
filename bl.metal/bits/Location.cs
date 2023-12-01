namespace snff.bl.metal;

public struct Location
{

    #region Fields
        public int map;
        public int map_x;
        public int map_y;
        public int map_z;
        public int loc;
        public int loc_x;
        public int loc_y;
        public int loc_z;
    #endregion

    public Location(int map, int map_x, int map_y, int map_z, int loc, int loc_x, int loc_y, int loc_z)
    {
        this.map = map;
        this.map_x = map_x;
        this.map_y = map_y;
        this.map_z = map_z;
        this.loc = loc;
        this.loc_x = loc_x;
        this.loc_y = loc_y;
        this.loc_z = loc_z;
    }

    public static Location Parse(double value)
    {
        return Parse(value.ToString());
    }

    public static Location Parse(double value)
    {
        
    }

    public static Location Parse(string value)
    {
        string[] parts = value.Split('.');
        string mapLoc = parts[0];
        string coordinates = parts[1];

        int map = int.Parse(mapLoc.Substring(0, 3));
        int loc = int.Parse(mapLoc.Substring(3, 3));
        int mxx = int.Parse(coordinates.Substring(0, 3));
        int myy = int.Parse(coordinates.Substring(3, 3));
        int mzz = int.Parse(coordinates.Substring(6, 3));
        int lxx = int.Parse(coordinates.Substring(9, 3));
        int lyy = int.Parse(coordinates.Substring(12, 3));
        int lzz = int.Parse(coordinates.Substring(15, 3));

        return new Location(map, mxx, myy, mzz, loc, lxx, lyy, lzz);
    }


}
