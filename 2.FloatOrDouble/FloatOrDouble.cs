﻿using System;
//Problem 2. Float or Double?
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.


class FloatOrDouble
{
    static void Main()
    {
        double doubleNumber = 34.567839023;
        float floatNumber = 12.345f;
        double secDoubleNumber = 8923.1234857;
        float secFloatNumber = 3456.091f;


        Console.WriteLine(doubleNumber);
        Console.WriteLine(floatNumber);
        Console.WriteLine(secDoubleNumber);
        Console.WriteLine(secFloatNumber);
    }
}

