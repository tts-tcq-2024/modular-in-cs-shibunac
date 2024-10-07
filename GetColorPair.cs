namespace TelCo.ColorCoder
{
/// <summary>
    /// Represents a pair of colors.
    /// </summary>
    public class ColorPair
    {
        public Color MajorColor { get; }
        public Color MinorColor { get; }

        public ColorPair(Color majorColor, Color minorColor)
        {
            MajorColor = majorColor;
            MinorColor = minorColor;
        }

        public override string ToString()
        {
            return $"MajorColor: {MajorColor.Name}, MinorColor: {MinorColor.Name}";
        }
    }
}
