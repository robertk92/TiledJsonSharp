namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#object
    public class TiledObject
    {
        /// <summary>
        /// Used to mark an object as an ellipse
        /// </summary>
        public bool Ellipse { get; set; }

        /// <summary>
        /// Global tile ID, only if object represents a tile
        /// </summary>
        public int Gid { get; set; }

        /// <summary>
        /// Height in pixels.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Incremental ID, unique across all objects
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// String assigned to name field in editor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Used to mark an object as a point
        /// </summary>
        public bool Point { get; set; }

        /// <summary>
        /// Array of Points, in case the object is a polygon
        /// </summary>
        public TiledPoint[] Polygon { get; set; }

        /// <summary>
        /// Array of Points, in case the object is a polyline
        /// </summary>
        public TiledPoint[] Polyline { get; set; }

        /// <summary>
        /// Array of Properties
        /// </summary>
        public TiledProperty[] Properties { get; set; }

        /// <summary>
        /// Angle in degrees clockwise
        /// </summary>
        public double Rotation { get; set; }

        /// <summary>
        /// Reference to a template file, in case object is a template instance
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// Only used for text objects
        /// </summary>
        public TiledText Text { get; set; }

        /// <summary>
        /// The class of the object (was saved as class in 1.9, optional)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Whether object is shown in editor.
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// Width in pixels.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// X coordinate in pixels
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate in pixels
        /// </summary>
        public double Y { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
