namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#wang-tile
    public class TiledWangTile
    {
        /// <summary>
        /// Local ID of tile
        /// </summary>
        public int TileId { get; set; }

        /// <summary>
        /// Array of Wang color indexes (uchar[8])
        /// </summary>
        public byte[] WangId { get; set; }
    }
}
