// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
public class CustomConverter
{
    public void Convert<T>(string value, out T result) where T : struct
    {
        // Определяем тип данных, который нужно преобразовать
        Type type = typeof(T);

        // Используем рефлексию для вызова соответствующего метода Convert
        if (type == typeof(int))
        {
            result = (T)(object)Convert.ToInt32(value);
        }
        else if (type == typeof(double))
        {
            result = (T)(object)Convert.ToDouble(value);
        }
        else if (type == typeof(bool))
        {
            result = (T)(object)Convert.ToBoolean(value);
        }
        else if (type == typeof(DateTime))
        {
            result = (T)(object)Convert.ToDateTime(value);
        }
        else
        {
            throw new ArgumentException("Неподдерживаемый тип данных.");
        }
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        CustomConverter converter = new CustomConverter();

        int intValue;
        converter.Convert("123", out intValue);
        Console.WriteLine($"Целое число: {intValue}");

        double doubleValue;
        converter.Convert("3.14", out doubleValue);
        Console.WriteLine($"Дробное число: {doubleValue}");

        bool boolValue;
        converter.Convert("true", out boolValue);
        Console.WriteLine($"Логическое значение: {boolValue}");

        DateTime dateTimeValue;
        converter.Convert("2023-12-25", out dateTimeValue);
        Console.WriteLine($"Дата: {dateTimeValue}");
    }
}

