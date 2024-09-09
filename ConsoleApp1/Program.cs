using System;

public class CustomConverter
{
    // Метод для преобразования строки в целое число
    public static bool TryConvert(string value, out int result)
    {
        return int.TryParse(value, out result);
    }

    // Метод для преобразования строки в число с плавающей точкой
    public static bool TryConvert(string value, out double result)
    {
        return double.TryParse(value, out result);
    }

    // Метод для преобразования строки в логическое значение
    public static bool TryConvert(string value, out bool result)
    {
        return bool.TryParse(value, out result);
    }

    // Метод для преобразования строки в DateTime
    public static bool TryConvert(string value, out DateTime result)
    {
        return DateTime.TryParse(value, out result);
    }

    // Метод для преобразования строки в десятичное число
    public static bool TryConvert(string value, out decimal result)
    {
        return decimal.TryParse(value, out result);
    }
}

class Program
{
    static void Main()
    {
        string input = "123";

        // Пример использования
        if (CustomConverter.TryConvert(input, out int intResult))
        {
            Console.WriteLine($"int result: {intResult}");
        }
        else
        {
            Console.WriteLine("chtoto");
        }

        if (CustomConverter.TryConvert(input, out double doubleResult))
        {
            Console.WriteLine($"double result: {doubleResult}");
        }
        else
        {
            Console.WriteLine("chtoto failed");
        }

        string boolInput = "True";
        if (CustomConverter.TryConvert(boolInput, out bool boolResult))
        {
            Console.WriteLine($"bool result: {boolResult}");
        }
        else
        {
            Console.WriteLine("Conversion to bool failed.");
        }

        string dateInput = "2024-09-09";
        if (CustomConverter.TryConvert(dateInput, out DateTime dateResult))
        {
            Console.WriteLine($"DateTime result: {dateResult}");
        }
        else
        {
            Console.WriteLine("Conversion to DateTime failed.");
        }

        if (CustomConverter.TryConvert(input, out decimal decimalResult))
        {
            Console.WriteLine($"decimal result: {decimalResult}");
        }
        else
        {
            Console.WriteLine("Conversion to decimal failed.");
        }
    }
}
