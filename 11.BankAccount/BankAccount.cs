using System;
//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.


class BankAccount
{
    static void Main()
    {
        string holderFirstName = "Veslin";
        string holderMiddleName = "Georgiev";
        string holderLastName = "Vasilev";
        decimal balance = 7.50M;
        string bankName = "DSK";
        string IBAN = "BG85STSA12345678912345";
        string BIC_Code = "STSABGSF";
        long creditCardNumber1 = 6776030078884332;
        long creditCardNumber2 = 1293129091298001;
        long creditCardNumber3 = 1209839102309111;



        Console.WriteLine("Holder name's: {0} {1} {2}\nHolder ballance in millions: {3}\nHolder bank name: {4}\nHolder IBAN: {5}\nHolder BIC: {6}\nHolder credit card number: {7}\nHolder credit card number: {8}\nHolder credit card number: {9}", 
            holderFirstName, holderMiddleName, holderLastName, balance, bankName, IBAN, BIC_Code, creditCardNumber1, creditCardNumber2, creditCardNumber3);
    }
}

