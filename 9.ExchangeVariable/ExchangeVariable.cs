using System;
//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
class ExchangeVariable
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange numbers are, a={0}\tb={1}", a, b);
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchange numbers are, a={0}\tb={1}", a, b);
    }
}

