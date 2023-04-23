namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#tile-offset   
    public class TiledTileOffset
    {
        /// <summary>
        /// Horizontal offset in pixels
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Vertical offset in pixels (positive is down)
        /// </summary>
        public int Y { get; set; }
    }
}
