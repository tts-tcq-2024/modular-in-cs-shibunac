using System.Drawing;

namespace ColorCoding
{
    /// <summary>
    /// Repository that holds the major and minor color mappings
    /// </summary>
    public static class ColorLibrary
    {
      public static readonly List<Color> MajorColors = new List<Color>
        {
          Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet
        };

      public static readonly List<Color> MinorColors = new List<Color>
        {
          Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray
        };
    }
}


