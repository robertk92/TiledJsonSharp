namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#chunk
    public class TiledChunk
    {
        /// <summary>
        /// Array of unsigned int (GIDs) or base64-encoded data string
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Height in tiles
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Width in tiles
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// X coordinate in tiles
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate in tiles
        /// </summary>
        public int Y { get; set; }
    }
}
