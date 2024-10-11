using System.Diagnostics;
using System.Drawing;

  /// <summary>
  /// Test class for the color code functionality.
  /// </summary>
  public class ColorCodeTester
  {
   private static void RunPairNumberToColorTests(ColorCodeMapper mapper)
  {
  // Test Case 1
  int pairNumber = 4;
  ColorPair expectedPair = new ColorPair("White", "Brown");
  ColorPair actualPair = mapper.GetColorFromPairNumber(pairNumber);
  Debug.Assert(actualPair.Equals(expectedPair), $"Test Failed: Expected {expectedPair}, Got {actualPair}");

  // Test Case 2
  pairNumber = 5;
  expectedPair = new ColorPair("White", "SlateGray");
  actualPair = mapper.GetColorFromPairNumber(pairNumber);
  Debug.Assert(actualPair.Equals(expectedPair), $"Test Failed: Expected {expectedPair}, Got {actualPair}");

  // Test Case 3
  pairNumber = 23;
  expectedPair = new ColorPair("Violet", "Green");
  actualPair = mapper.GetColorFromPairNumber(pairNumber);
  Debug.Assert(actualPair.Equals(expectedPair), $"Test Failed: Expected {expectedPair}, Got {actualPair}");
  }
    private static void RunColorToPairNumberTests(ColorCodeMapper mapper)
{
  // Test Case 1
  ColorPair testPair = new ColorPair("Yellow", "Green");
  int expectedPairNumber = 18;
  int actualPairNumber = mapper.GetPairNumberFromColor(testPair);
  Debug.Assert(actualPairNumber == expectedPairNumber, $"Test Failed: Expected {expectedPairNumber}, Got {actualPairNumber}");

  // Test Case 2
  testPair = new ColorPair("Red", "Blue");
  expectedPairNumber = 6;
  actualPairNumber = mapper.GetPairNumberFromColor(testPair);
  Debug.Assert(actualPairNumber == expectedPairNumber, $"Test Failed: Expected {expectedPairNumber}, Got {actualPairNumber}");
}
  }
}
