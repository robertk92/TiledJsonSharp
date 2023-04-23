namespace TiledJsonSharp
{
    // https://doc.mapeditor.org/en/latest/reference/json-map-format/#text
    public class TiledText
    {
        /// <summary>
        /// Whether to use a bold font (default: false)
        /// </summary>
        public bool Bold { get; set; }

        /// <summary>
        /// Hex-formatted color (#RRGGBB or #AARRGGBB) (default: #000000)
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Font family (default: sans-serif)
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Horizontal alignment (center, right, justify or left (default))
        /// </summary>
        public string HAlign { get; set; }

        /// <summary>
        /// Whether to use an italic font (default: false)
        /// </summary>
        public bool Italic { get; set; }

        /// <summary>
        /// Whether to use kerning when placing characters (default: true)
        /// </summary>
        public bool Kerning { get; set; }

        /// <summary>
        /// Pixel size of font (default: 16)
        /// </summary>
        public int PixelSize { get; set; }

        /// <summary>
        /// Whether to strike out the text (default: false)
        /// </summary>
        public bool Strikeout { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Whether to underline the text (default: false)
        /// </summary>
        public bool Underline { get; set; }

        /// <summary>
        /// Vertical alignment (center, bottom or top (default))
        /// </summary>
        public string VAlign { get; set; }

        /// <summary>
        /// Whether the text is wrapped within the object bounds (default: false)
        /// </summary>
        public bool Wrap { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
