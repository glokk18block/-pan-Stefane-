using System;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
     
        string numberString = n.ToString();

        
        string resultString = string.Concat(numberString.Select(c => (int)Math.Pow(char.GetNumericValue(c), 2)));

      
        return int.Parse(resultString);
    }
}