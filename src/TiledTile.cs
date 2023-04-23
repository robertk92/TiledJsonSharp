namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#tile-definition
    public class TiledTile
    {
        /// <summary>
        /// Array of Frames
        /// </summary>
        public TiledFrame[] Animation { get; set; }

        /// <summary>
        /// Local ID of the tile
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Image representing this tile (optional, used for image collection tilesets)
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Height of the tile image in pixels
        /// </summary>
        public int ImageHeight { get; set; }

        /// <summary>
        /// Width of the tile image in pixels
        /// </summary>
        public int ImageWidth { get; set; }

        /// <summary>
        /// The X position of the sub-rectangle representing this tile (default: 0)
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The Y position of the sub-rectangle representing this tile (default: 0)
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// The width of the sub-rectangle representing this tile (defaults to the image width)
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// The height of the sub-rectangle representing this tile (defaults to the image height)
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Layer with type objectgroup, when collision shapes are specified (optional)
        /// </summary>
        public TiledLayer ObjectGroup { get; set; }

        /// <summary>
        /// Percentage chance this tile is chosen when competing with others in the editor (optional)
        /// </summary>
        public double Probability { get; set; }

        /// <summary>
        /// Array of Properties
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// Index of terrain for each corner of tile (optional, replaced by Wang sets since 1.5)
        /// </summary>
        public int[] Terrain { get; set; }

        /// <summary>
        /// The class of the tile (was saved as class in 1.9, optional)
        /// </summary>
        public string Type { get; set; }
    }
}
