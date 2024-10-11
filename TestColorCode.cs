using ColorCoding;
using System.Diagnostics;
using System.Drawing;

/// <summary>
/// Test class for the color code functionality.
/// </summary>
public class TestColorCode
{

  public void RunPairNumberToColorTests()
  {
    // Test Case 1
    int pairNumber = 4;
    var mapper = new ColorCodeMapper();
    ColorPair expectedPair = new ColorPair(Color.White, Color.Brown);
    ColorPair actualPair = mapper.GetColorFromPairNumber(pairNumber);
    Debug.Assert(actualPair.Equals(expectedPair), $"Test Failed: Expected {expectedPair}, Got {actualPair}");

    // Test Case 2
    pairNumber = 5;
    expectedPair = new ColorPair(Color.White, Color.SlateGray);
    actualPair = mapper.GetColorFromPairNumber(pairNumber);
    Debug.Assert(actualPair.Equals(expectedPair), $"Test Failed: Expected {expectedPair}, Got {actualPair}");

    // Test Case 3
    pairNumber = 23;
    expectedPair = new ColorPair(Color.Violet, Color.Green);
    actualPair = mapper.GetColorFromPairNumber(pairNumber);
    Debug.Assert(actualPair.Equals(expectedPair), $"Test Failed: Expected {expectedPair}, Got {actualPair}");
  }
  public void RunColorToPairNumberTests()
  {
    // Test Case 1
    var mapper = new ColorCodeMapper();
    ColorPair testPair = new ColorPair(Color.Yellow, Color.Green);
    int expectedPairNumber = 18;
    int actualPairNumber = mapper.GetPairNumberFromColor(testPair);
    Debug.Assert(actualPairNumber == expectedPairNumber, $"Test Failed: Expected {expectedPairNumber}, Got {actualPairNumber}");

    // Test Case 2
    testPair = new ColorPair(Color.Red, Color.Blue);
    expectedPairNumber = 6;
    actualPairNumber = mapper.GetPairNumberFromColor(testPair);
    Debug.Assert(actualPairNumber == expectedPairNumber, $"Test Failed: Expected {expectedPairNumber}, Got {actualPairNumber}");
  }
}
