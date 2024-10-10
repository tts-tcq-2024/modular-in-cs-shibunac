using Xunit;
using ColorCoding;
using System.Diagnostics;
using System.Drawing;

  /// <summary>
  /// Test class for the color code functionality.
  /// </summary>
  public class ColorCodeTester
  {
    public void RunTest()
    {
      TestColorPairGivenPairNumber();
      TestColorPairGivenPairNumber2();
      TestColorPairGivenPairNumberTwoDigit();
      TestPairNumberGivenColorPair();
      TestPairNumberGivenColorPair2();
    }
    
  [Fact]
  public void TestColorPairGivenPairNumber()
  {
    var colorCodeMapper = new ColorCodeMapper();
    int pairNumber = 4;
    ColorPair testPair1 = colorCodeMapper.GetColorFromPairNumber(pairNumber);
    Assert.Equal(testPair1.MajorColor , Color.White);
    Assert.Equal(testPair1.MinorColor ,(Color.Brown));
  }

 [Fact]
 public void TestColorPairGivenPairNumber2()
 {
   var colorCodeMapper = new ColorCodeMapper();
   int pairNumber = 5;
   ColorPair testPair1 = colorCodeMapper.GetColorFromPairNumber(pairNumber);
   Assert.Equal(testPair1.MajorColor,(Color.White));
   Assert.Equal(testPair1.MinorColor,(Color.SlateGray));
 }

 [Fact]
 public void TestColorPairGivenPairNumberTwoDigit()
 {
   var colorCodeMapper = new ColorCodeMapper();
   int pairNumber = 23;
   ColorPair testPair1 = colorCodeMapper.GetColorFromPairNumber(pairNumber);
   Assert.True(testPair1.MajorColor.Equals(Color.Violet));
   Assert.True(testPair1.MinorColor.Equals(Color.Green));
 }

    [Fact]
public void TestPairNumberGivenColorPair()
{
  var colorCodeMapper = new ColorCodeMapper();
  ColorPair testPair2 = new ColorPair(Color.Yellow, Color.Green);
  int pairNumber = colorCodeMapper.GetPairNumberFromColor(testPair2);
  Assert.True(pairNumber == 18);
}

[Fact]
public void TestPairNumberGivenColorPair2()
{
  var colorCodeMapper = new ColorCodeMapper();
  ColorPair testPair2 = new ColorPair(Color.Red, Color.Blue);
  int pairNumber = colorCodeMapper.GetPairNumberFromColor(testPair2);
  Assert.True(pairNumber == 6);
}
    
}
