namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#property
    public class TiledProperty
    {
        /// <summary>
        /// Name of the property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the property (string (default), int, float, bool, color, file, object
        /// or class (since 0.16, with color and file added in 0.17, object added in 1.4 and class added in 1.8))
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Name of the custom property type, when applicable (since 1.8)
        /// </summary>
        public string PropertyType { get; set; }

        /// <summary>
        /// Value of the property
        /// </summary>
        public object Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
