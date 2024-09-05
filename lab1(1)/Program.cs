// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
public class CustomConverter
{    // Преобразование строки в int
    public void ConvertToInt(string input, out int result)
    {
        result = Convert.ToInt32(input);
    }
    // Преобразование строки в long
    public void ConvertToLong(string input, out long result)
    {
        result = Convert.ToInt64(input);
    }
    // Преобразование строки в double
    public void ConvertToDouble(string input, out double result)
    {
        if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out result))        
        {
            throw new FormatException($"Input string '{input}' was not in a correct format.");
        }
    }
    // Преобразование строки в bool
    public void ConvertToBool(string input, out bool result)
    {
        result = Convert.ToBoolean(input);
    }
    // Преобразование строки в DateTime
    public void ConvertToDateTime(string input, out DateTime result)
    {
        result = Convert.ToDateTime(input);
    }
}
class Program
{
    static void Main()
    {
        CustomConverter converter = new CustomConverter();
        string numberString = "123";
        converter.ConvertToInt(numberString, out int intValue); Console.WriteLine($"Converted to int: {intValue}");
        string longString = "123456789";
        converter.ConvertToLong(longString, out long longValue); Console.WriteLine($"Converted to long: {longValue}");
        string doubleString = "123.2";
        converter.ConvertToDouble(doubleString, out double doubleValue); Console.WriteLine($"Converted to double: {doubleValue}");
        string boolString = "true";
        converter.ConvertToBool(boolString, out bool boolValue); Console.WriteLine($"Converted to bool: {boolValue}");
        string dateString = "2024-9-02 2:30:10";
        converter.ConvertToDateTime(dateString, out DateTime dateValue); Console.WriteLine($"Converted to DateTime: {dateValue}");
       
    }
}
