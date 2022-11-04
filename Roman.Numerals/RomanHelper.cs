using System.Security.Cryptography.X509Certificates;

namespace Roman.Numerals;
public class RomanHelper
{
    public static string Convert(int inArabic)
    {
        if (inArabic == 0)
        {
            return string.Empty;
        }

        Tuple<int, string> tuple = GetConversionFactor(inArabic);

        return tuple.Item2 + Convert(inArabic - tuple.Item1);
    }

    private static List<Tuple<int, string>> _pairs = new List<Tuple<int, string>>()
    {
        new Tuple<int, string>(1000, "M"),
        new Tuple<int, string>(900, "CM"),
        new Tuple<int, string>(500, "D"),
        new Tuple<int, string>(400, "CD"),
        new Tuple<int, string>(100, "C"),
        new Tuple<int, string>(90, "XC"),
        new Tuple<int, string>(50, "L"),
        new Tuple<int, string>(40, "XL"),
        new Tuple<int, string>(10, "X"),
        new Tuple<int, string>(9, "IX"),
        new Tuple<int, string>(5, "V"),
        new Tuple<int, string>(4, "IV"),
        new Tuple<int, string>(1, "I")
    };

    private static Tuple<int, string> GetConversionFactor(int inArabic)
    {

        Tuple<int, string> tuple = _pairs.Find(x => x.Item1 <= inArabic) ?? new Tuple<int, string>(0, "");
        return tuple;
    }
}
