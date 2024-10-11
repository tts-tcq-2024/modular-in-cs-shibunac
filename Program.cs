namespace ColorCoding
{
 class Program
{
  public static void Main(string[] args)
  {
    var colorCodeTest = new ColorCodeTester();
    colorCodeTest.RunPairNumberToColorTests();
    colorCodeTest.RunColorToPairNumberTests();
    
  }
}
}
