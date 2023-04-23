namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#transformations
    public class TiledTransformations
    {
        /// <summary>
        /// Tiles can be flipped horizontally
        /// </summary>
        public bool HFlip { get; set; }

        /// <summary>
        /// Tiles can be flipped vertically
        /// </summary>
        public bool VFlip { get; set; }

        /// <summary>
        /// Tiles can be rotated in 90-degree increments
        /// </summary>
        public bool Rotate { get; set; }

        /// <summary>
        /// Whether untransformed tiles remain preferred, otherwise transformed tiles are used to produce more variations
        /// </summary>
        public bool PreferUntransformed { get; set; }
    }
}
