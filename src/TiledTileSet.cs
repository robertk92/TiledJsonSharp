namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#tileset
    public class TiledTileSet
    {
        /// <summary>
        /// Hex-formatted color (#RRGGBB or #AARRGGBB) (optional)
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// The class of the tileset (since 1.9, optional)
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// The number of tile columns in the tileset
        /// </summary>
        public int Columns { get; set; }

        /// <summary>
        /// The fill mode to use when rendering tiles from this tileset (stretch (default) or preserve-aspect-fit) (since 1.9)
        /// </summary>
        public string FillMode { get; set; }

        /// <summary>
        /// GID corresponding to the first tile in the set
        /// </summary>
        public int FirstGid { get; set; }

        /// <summary>
        /// (optional)
        /// </summary>
        public TiledGrid Grid { get; set; }

        /// <summary>
        /// Image used for tiles in this set
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Height of source image in pixels
        /// </summary>
        public int ImageHeight { get; set; }

        /// <summary>
        /// Width of source image in pixels
        /// </summary>
        public int ImageWidth { get; set; }

        /// <summary>
        /// Buffer between image edge and first tile (pixels)
        /// </summary>
        public int Margin { get; set; }

        /// <summary>
        /// Name given to this tileset
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Alignment to use for tile objects (unspecified (default), topleft, top, topright, left, center, right, bottomleft, bottom or bottomright) (since 1.4)
        /// </summary>
        public string ObjectAlignment { get; set; }

        /// <summary>
        /// Array of Properties
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// The external file that contains this tilesets data
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Spacing between adjacent tiles in image (pixels)
        /// </summary>
        public int Spacing { get; set; }

        /// <summary>
        /// Array of Terrains (optional)
        /// </summary>
        public TiledTerrain[] Terrains { get; set; }

        /// <summary>
        /// The number of tiles in this tileset
        /// </summary>
        public int TileCount { get; set; }

        /// <summary>
        /// The Tiled version used to save the file
        /// </summary>
        public string TiledVersion { get; set; }

        /// <summary>
        /// Maximum height of tiles in this set
        /// </summary>
        public int TileHeight { get; set; }

        /// <summary>
        /// (optional)
        /// </summary>
        public TiledTileOffset TileOffset { get; set; }

        /// <summary>
        /// The size to use when rendering tiles from this tileset on a tile layer (tile (default) or grid) (since 1.9)
        /// </summary>
        public string TileRenderSize { get; set; }

        /// <summary>
        /// Array of Tiles (optional)
        /// </summary>
        public TiledTile[] Tiles { get; set; }

        /// <summary>
        /// Maximum width of tiles in this set
        /// </summary>
        public int TileWidth { get; set; }

        /// <summary>
        /// Allowed transformations (optional)
        /// </summary>
        public TiledTransformations Transformations { get; set; }
        
        /// <summary>
        /// Hex-formatted color (#RRGGBB) (optional)
        /// </summary>
        public string TransparentColor { get; set; }

        /// <summary>
        /// tileset (for tileset files, since 1.0)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The JSON format version (previously a number, saved as string since 1.6)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Array of Wang sets (since 1.1.5)
        /// </summary>
        public TiledWangSet[] WangSets { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
