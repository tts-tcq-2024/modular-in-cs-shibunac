using System.Drawing;

namespace ColorCoding
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
    
    // Override Equals to compare values
    public override bool Equals(object obj)
    {
        if (obj is ColorPair otherPair)
        {
            return this.MajorColor == otherPair.MajorColor && this.MinorColor == otherPair.MinorColor;
        }
        return false;
    }

    // Override GetHashCode for consistency with Equals
    public override int GetHashCode()
    {
        return (MajorColor, MinorColor).GetHashCode();
    }
  }
}
