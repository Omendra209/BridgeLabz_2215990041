using System;
using System.Text.RegularExpressions;

public class IPAddressValidator
{
    public static void Main(string[] args)
    {
        string ip = "192.168.1.1";
        string invalidIP = "256.256.256.256";

        Console.WriteLine(ValidateIPAddress(ip));           
        Console.WriteLine(ValidateIPAddress(invalidIP));    
    }

    public static string ValidateIPAddress(string ip)
    {
        Regex ipRegex = new Regex(@"^([0-9]{1,3}\.){3}[0-9]{1,3}$");

        if (ipRegex.IsMatch(ip) && ValidateOctets(ip))
        {
            return "Valid";
        }
        else
        {
            return "Invalid";
        }
    }

    private static bool ValidateOctets(string ip)
    {
        string[] parts = ip.Split('.');
        foreach (var part in parts)
        {
            if (int.Parse(part) < 0 || int.Parse(part) > 255)
            {
                return false;
            }
        }
        return true;
    }
}
