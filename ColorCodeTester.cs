using Xunit;
using ColorCoding;
using System.Diagnostics;
using System.Drawing;

  /// <summary>
  /// Test class for the color code functionality.
  /// </summary>
  public class ColorCodeTester
  {


  [Fact]
    public static void ColorCodeTest1()
    {
      var colorCodeMapper = new ColorCodeMapper();
      int pairNumber = 4;
      ColorPair testPair1 = colorCodeMapper.GetColorFromPairNumber(pairNumber);
      Assert.Equal(testPair1.MajorColor , Color.White);
      Assert.Equal(testPair1.MinorColor ,(Color.Brown));
    }
  }
