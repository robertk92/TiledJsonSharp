namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#terrain
    public class TiledTerrain
    {
        /// <summary>
        /// Name of terrain
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Array of Properties
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// Local ID of tile representing terrain
        /// </summary>
        public int Tile { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
