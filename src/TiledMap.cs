using System.IO;
using System.Text.Json;

namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#map
    public class TiledMap
    {
        /// <summary>
        /// Hex-formatted color (#RRGGBB or #AARRGGBB) (optional)
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// The class of the map (since 1.9, optional)
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// The compression level to use for tile layer data (defaults to -1, which means to use the algorithm default)
        /// </summary>
        public int CompressionLevel { get; set; }

        /// <summary>
        /// Number of tile rows
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Length of the side of a hex tile in pixels (hexagonal maps only)
        /// </summary>
        public int HexSideLength { get; set; }

        /// <summary>
        /// Whether the map has infinite dimensions
        /// </summary>
        public bool Infinite { get; set; }

        /// <summary>
        /// Array of Layers
        /// </summary>
        public TiledLayer[] Layers { get; set; }

        /// <summary>
        /// Auto-increments for each layer
        /// </summary>
        public int NextLayerId { get; set; }

        /// <summary>
        /// Auto-increments for each placed object
        /// </summary>
        public int NextObjectId { get; set; }

        /// <summary>
        /// orthogonal, isometric, staggered or hexagonal
        /// </summary>
        public string Orientation { get; set; }

        /// <summary>
        /// X coordinate of the parallax origin in pixels (since 1.8, default: 0)
        /// </summary>
        public double ParallaxOriginX { get; set; }

        /// <summary>
        /// Y coordinate of the parallax origin in pixels (since 1.8, default: 0)
        /// </summary>
        public double ParallaxOriginY { get; set; }

        /// <summary>
        /// Array of Properties
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// right-down (the default), right-up, left-down or left-up (currently only supported for orthogonal maps)
        /// </summary>
        public string RenderOrder { get; set; }

        /// <summary>
        /// x or y (staggered / hexagonal maps only)
        /// </summary>
        public string StaggerAxis { get; set; }

        /// <summary>
        /// odd or even (staggered / hexagonal maps only)
        /// </summary>
        public string StaggerIndex { get; set; }

        /// <summary>
        /// The Tiled version used to save the file
        /// </summary>
        public string TiledVersion { get; set; }

        /// <summary>
        /// Map grid height
        /// </summary>
        public int TileHeight { get; set; }

        /// <summary>
        /// Array of Tilesets
        /// </summary>
        public TiledTileSet[] TileSets { get; set; }

        /// <summary>
        /// Map grid width
        /// </summary>
        public int TileWidth { get; set; }

        /// <summary>
        /// map (since 1.0)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The JSON format version (previously a number, saved as string since 1.6)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Number of tile columns
        /// </summary>
        public int Width { get; set; }
        
        public static TiledMap FromStream(Stream stream)
        {
            byte[] bytes = StreamUtil.ReadAllBytes(stream);
            using(JsonDocument document = JsonDocument.Parse(bytes)) {
                return TiledParser.ParseMap(document.RootElement);
            }
        }
    }
}
