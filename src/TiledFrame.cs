namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#json-frame
    public class TiledFrame
    {
        /// <summary>
        /// Frame duration in milliseconds
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Local tile ID representing this frame
        /// </summary>
        public int TileId { get; set; }
    }
}
