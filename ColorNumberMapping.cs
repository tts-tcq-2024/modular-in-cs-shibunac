using System;
using System.Drawing;

namespace ColorCoding
{
  /// <summary>
  /// Handles mapping between pair numbers and color pairs.
  /// </summary>
  public class ColorCodeMapper
  {
    private readonly int _majorSize;
    private readonly int _minorSize;

    public ColorCodeMapper()
    {
      _majorSize = ColorLibrary.MajorColors.Count;
      _minorSize = ColorLibrary.MinorColors.Count;
    }

    /// <summary>
    /// Given a pair number, returns the corresponding ColorPair.
    /// </summary>
    /// <param name="pairNumber">Pair number (1-based index).</param>
    /// <returns>ColorPair corresponding to the pair number.</returns>
    public ColorPair GetColorFromPairNumber(int pairNumber)
    {
      if (pairNumber < 1 || pairNumber > _majorSize * _minorSize)
      {
        throw new ArgumentOutOfRangeException(nameof(pairNumber),
            $"Pair number must be between 1 and {_majorSize * _minorSize}.");
      }

      int zeroBasedPairNumber = pairNumber - 1;
      int majorIndex = zeroBasedPairNumber / _minorSize;
      int minorIndex = zeroBasedPairNumber % _minorSize;

      Color majorColor = ColorLibrary.MajorColors[majorIndex];
      Color minorColor = ColorLibrary.MinorColors[minorIndex];

      return new ColorPair(majorColor, minorColor);
    }

    /// <summary>
    /// Given a ColorPair, returns the corresponding pair number.
    /// </summary>
    /// <param name="pair">ColorPair to be mapped.</param>
    /// <returns>Pair number corresponding to the ColorPair.</returns>
    public int GetPairNumberFromColor(ColorPair pair)
    {
      if (pair == null)
        throw new ArgumentNullException(nameof(pair));

      int majorIndex = ColorLibrary.MajorColors.IndexOf(pair.MajorColor);
      int minorIndex = ColorLibrary.MinorColors.IndexOf(pair.MinorColor);

      if (majorIndex == -1 || minorIndex == -1)
      {
        throw new ArgumentException($"Unknown Colors: {pair}");
      }

      return (majorIndex * _minorSize) + (minorIndex + 1);
    }
  }
}
