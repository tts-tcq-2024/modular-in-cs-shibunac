namespace ColorCoding
{
 class Program
{
  public static void Main(string[] args)
  {
    ColorCodeTester colorCodeTest = new TestColorCode();
    colorCodeTest.RunPairNumberToColorTests();
    colorCodeTest.RunColorToPairNumberTests();
    
  }
}
}
