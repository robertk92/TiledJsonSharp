namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#grid
    /// <summary>
    /// Specifies common grid settings used for tiles in a tileset.
    /// </summary>
    public class TiledGrid
    {
        /// <summary>
        /// Cell height of tile grid
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// orthogonal (default) or isometric
        /// </summary>
        public string Orientation { get; set; }

        /// <summary>
        /// Cell width of tile grid
        /// </summary>
        public int Width { get; set; }
    }
}
