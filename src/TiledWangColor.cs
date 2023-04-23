namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#wang-color
    public class TiledWangColor
    {
        /// <summary>
        /// The class of the Wang color (since 1.9, optional)
        /// </summary>
        public string Class { get; set; }
     
        /// <summary>
        /// Hex-formatted color (#RRGGBB or #AARRGGBB)
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Name of the Wang color
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Probability used when randomizing
        /// </summary>
        public double Probability { get; set; }

        /// <summary>
        /// Array of Properties (since 1.5)
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// Local ID of tile representing the Wang color
        /// </summary>
        public int Tile { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
