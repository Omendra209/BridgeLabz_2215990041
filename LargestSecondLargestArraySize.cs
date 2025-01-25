using System;

public class LargestSecondLargestArraySize {
    public static void Main(string[] args) {
        // Taking user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Define initial variables
        int maxDigit = 10; // Maximum initial size of the array
        int[] digits = new int[maxDigit]; // Array to store digits
        int index = 0; // Index to keep track of the array position

        // Loop to store digits of the number into the array
        while (number != 0) {
            // If the array is full, resize it
            if (index == maxDigit) {
                maxDigit += 10; // Increase the size by 10
                int[] temp = new int[maxDigit]; // Create a new array with the increased size
                Array.Copy(digits, temp, digits.Length); // Copy old elements to the new array
                digits = temp; // Reassign digits to the new array
            }

            digits[index] = number % 10; // Get the last digit
            number /= 10; // Remove the last digit
            index++; // Increment index
        }

        // Variables to store the largest and second largest digits
        int largest = 0, secondLargest = 0;

        // Loop through the array to find the largest and second largest digits
        for (int i = 0; i < index; i++) {
            if (digits[i] > largest) {
                secondLargest = largest;
                largest = digits[i];
            } else if (digits[i] > secondLargest && digits[i] != largest) {
                secondLargest = digits[i];
            }
        }

        // Display the largest and second largest digit
        Console.WriteLine("The largest digit is: " + largest);
        Console.WriteLine("The second largest digit is: " + secondLargest);
    }
}
