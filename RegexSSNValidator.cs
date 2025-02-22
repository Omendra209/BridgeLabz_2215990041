using System;
using System.Text.RegularExpressions;

public class SSNValidator
{
    public static void Main(string[] args)
    {
        string ssn1 = "123-45-6789";
        string ssn2 = "123456789";

        Console.WriteLine(ValidateSSN(ssn1));  // Valid
        Console.WriteLine(ValidateSSN(ssn2));  // Invalid
    }

    public static string ValidateSSN(string ssn)
    {
        Regex ssnRegex = new Regex(@"^\d{3}-\d{2}-\d{4}$");

        if (ssnRegex.IsMatch(ssn))
        {
            return ssn + " is valid";
        }
        else
        {
            return ssn + " is invalid";
        }
    }
}
