using System;



// Custom exception class
class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}



class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());



            if (number < 0)
            {
                throw new NegativeNumberException("Negative numbers are not allowed.");
            }



            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }



        Console.WriteLine("Program finished.");
    }
}