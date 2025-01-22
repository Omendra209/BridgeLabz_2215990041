// Creating a class with the name FindAge indicating the purpose is to find the age.
using System;
class FindAge {
    public static void Main(string[] args) {
     
        // Create a string variable 'name' and assign value "Harry"
        string name = "Harry";
     
        // Create an int variable for Year Of Birth as 'yob' and assign value 2000
        int yob = 2000;
     
        // Create a int variable 'currentYear' and assign value 2024
        int currentYear = 2024;
     
        // Create a int variable 'age' and assign harry's age (currentYear-yob)
        int age = currentYear - yob;
        
        // Display the age
        Console.WriteLine(name+”'s age in 2024 is “+age);
    }
}