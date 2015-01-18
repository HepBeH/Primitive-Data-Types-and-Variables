using System;
//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.


class ComparingFloats
{
    static void Main()
    {
        Console.Write("Write first floating point number: ");
        double one = double.Parse(Console.ReadLine());

        Console.Write("Write second floating point number: ");
        double two = double.Parse(Console.ReadLine());

        bool equal = Math.Abs(one - two) < 0.000001;

        Console.WriteLine("The numbers are{0}equal.", equal ? " " : " NOT ");
    }
}

