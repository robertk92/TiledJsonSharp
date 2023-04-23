namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#wang-set
    public class TiledWangSet
    {
        /// <summary>
        /// The class of the Wang set (since 1.9, optional)
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Array of Wang colors (since 1.5)
        /// </summary>
        public TiledWangColor[] Colors { get; set; }

        /// <summary>
        /// Name of the Wang set
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Array of Properties
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// Local ID of tile representing the Wang set
        /// </summary>
        public int Tile { get; set; }

        /// <summary>
        /// corner, edge or mixed (since 1.5)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Array of Wang tiles
        /// </summary>
        public TiledWangTile[] WangTiles { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
