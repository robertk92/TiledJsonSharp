using System.IO;
using System.Text.Json;

namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#object-template
    public class TiledObjectTemplate
    {
        /// <summary>
        /// template
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// External tileset used by the template (optional)
        /// </summary>
        public TiledTileSet TileSet { get; set; }

        /// <summary>
        /// The object instantiated by this template
        /// </summary>
        public TiledObject Object { get; set; }

        public static TiledObjectTemplate FromStream(Stream stream)
        {
            byte[] bytes = StreamUtil.ReadAllBytes(stream);
            using(JsonDocument document = JsonDocument.Parse(bytes)) {
                return TiledParser.ParseObjectTemplate(document.RootElement);
            }
        }
    }
}
