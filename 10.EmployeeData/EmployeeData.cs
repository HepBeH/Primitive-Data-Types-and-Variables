using System;
//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.

class EmployeeData
{
    static void Main()
    {
        Console.Write("Your first name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Your last name: ");
        string LastName = Console.ReadLine();
        Console.Write("Your age: ");
        int Age = int.Parse(Console.ReadLine());
        Console.Write("Your gender: ");
        string Gender = Console.ReadLine();
        Console.Write("Your personal ID number: ");
        long PersonalID = int.Parse(Console.ReadLine());
        Console.Write("Your Employee number: ");
        long EmployeeNumber = long.Parse(Console.ReadLine());

        
        Console.WriteLine("First name: {0} \nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nEmployee number: {5}" , 
            FirstName, LastName, Age, Gender, PersonalID, EmployeeNumber);

    }
}

