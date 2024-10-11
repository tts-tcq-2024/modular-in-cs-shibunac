namespace ColorCoding
{
 class Program
{
  public static void Main(string[] args)
  {
    var mapper = new ColorCodeMapper();
    var colorCodeTest = new ColorCodeTester();
    colorCodeTest.RunPairNumberToColorTests(mapper);
    colorCodeTest.RunColorToPairNumberTests(mapper);
    
  }
}
}
