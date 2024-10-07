namespace TelCo.ColorCoder
{
    /// <summary>
    /// Test class for the color code functionality.
    /// </summary>
    public class ColorCodeTester
    {
        public static void Main(string[] args)
        {
            var colorCodeMapper = new ColorCodeMapper();

            int pairNumber = 4;
            ColorPair testPair1 = colorCodeMapper.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0}, [Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor.Equals(new Color("White")));
            Debug.Assert(testPair1.MinorColor.Equals(new Color("Brown")));

            pairNumber = 5;
            testPair1 = colorCodeMapper.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0}, [Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor.Equals(new Color("White")));
            Debug.Assert(testPair1.MinorColor.Equals(new Color("SlateGray")));

            pairNumber = 23;
            testPair1 = colorCodeMapper.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0}, [Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.MajorColor.Equals(new Color("Violet")));
            Debug.Assert(testPair1.MinorColor.Equals(new Color("Green")));

            ColorPair testPair2 = new ColorPair(new Color("Yellow"), new Color("Green"));
            pairNumber = colorCodeMapper.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair(new Color("Red"), new Color("Blue"));
            pairNumber = colorCodeMapper.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}
