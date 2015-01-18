using System;
//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class NullValues
{
    static void Main()
    {
        int? intNumber = null;
        double? dNumber = null;
        Console.WriteLine("Null value: {0}\nNull value: {1}", intNumber, dNumber);

        intNumber += null;
        dNumber += null;

        Console.WriteLine("Added Null to Null: {0}\nAdded Null to Null: {1}", intNumber, dNumber);

        intNumber = intNumber.GetValueOrDefault() + 20;
        dNumber = dNumber.GetValueOrDefault() + 25.50;

        Console.WriteLine("Added 20 to NUll: {0}\nAdded 25.50 to Null: {1}", intNumber, dNumber);

        
    }
    
}

