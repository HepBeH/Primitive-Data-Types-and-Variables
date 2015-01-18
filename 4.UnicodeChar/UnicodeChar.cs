using System;
//Problem 4. Unicode Character
//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
class UnicodeChar
{
    static void Main()
    {
        int number = 42;
        Console.WriteLine("The hexadecimal representation of code 42 is: {0:X}", number);
        char symbol = '\u002A';
        Console.WriteLine("The symbol is: {0}", symbol);

    }
}

