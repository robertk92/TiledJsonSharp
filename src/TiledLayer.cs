using System;

namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#layer
    public class TiledLayer
    {
        /// <summary>
        /// Array of chunks (optional). tilelayer only.
        /// </summary>
        public TiledChunk[] Chunks { get; set; }

        /// <summary>
        /// The class of the layer (since 1.9, optional)
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// zlib, gzip, zstd (since Tiled 1.3) or empty (default). tilelayer only.
        /// </summary>
        public string Compression { get; set; }

        /// <summary>
        /// Array of unsigned int (GIDs) or base64-encoded data string. tilelayer only.
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// topdown (default) or index. objectgroup only.
        /// </summary>
        public string DrawOrder { get; set; }

        /// <summary>
        /// csv (default) or base64. tilelayer only.
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// Row count. Same as map height for fixed-size maps. tilelayer only.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Incremental ID - unique across all layers
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Image used by this layer. imagelayer only.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Array of layers. group only.
        /// </summary>
        public TiledLayer[] Layers { get; set; }

        /// <summary>
        /// Whether layer is locked in the editor (default: false). (since Tiled 1.8.2)
        /// </summary>
        public bool Locked { get; set; }

        /// <summary>
        /// Name assigned to this layer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Array of objects. objectgroup only.
        /// </summary>
        public TiledObject[] Objects { get; set; }

        /// <summary>
        /// Horizontal layer offset in pixels (default: 0)
        /// </summary>
        public double OffsetX { get; set; }

        /// <summary>
        /// Vertical layer offset in pixels (default: 0)
        /// </summary>
        public double OffsetY { get; set; }

        /// <summary>
        /// Value between 0 and 1
        /// </summary>
        public double Opacity { get; set; }

        /// <summary>
        /// Horizontal parallax factor for this layer (default: 1). (since Tiled 1.5)
        /// </summary>
        public double ParallaxX { get; set; }

        /// <summary>
        /// Vertical parallax factor for this layer (default: 1). (since Tiled 1.5)
        /// </summary>
        public double ParallaxY { get; set; }

        /// <summary>
        /// Array of Properties
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// Whether the image drawn by this layer is repeated along the X axis. imagelayer only. (since Tiled 1.8)
        /// </summary>
        public bool RepeatX { get; set; }

        /// <summary>
        /// Whether the image drawn by this layer is repeated along the Y axis. imagelayer only. (since Tiled 1.8)
        /// </summary>
        public bool RepeatY { get; set; }

        /// <summary>
        /// X coordinate where layer content starts (for infinite maps)
        /// </summary>
        public int StartX { get; set; }

        /// <summary>
        /// Y coordinate where layer content starts (for infinite maps)
        /// </summary>
        public int StartY { get; set; }

        /// <summary>
        /// Hex-formatted tint color (#RRGGBB or #AARRGGBB) that is multiplied with any graphics drawn by this layer or any child layers (optional).
        /// </summary>
        public string TintColor { get; set; }

        /// <summary>
        /// Hex-formatted color (#RRGGBB) (optional). imagelayer only.
        /// </summary>
        public string TransparentColor { get; set; }

        /// <summary>
        /// tilelayer, objectgroup, imagelayer or group
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Whether layer is shown or hidden in editor
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// Column count. Same as map width for fixed-size maps. tilelayer only.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Horizontal layer offset in tiles. Always 0.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Vertical layer offset in tiles. Always 0.
        /// </summary>
        public int Y { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
