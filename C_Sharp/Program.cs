using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Currency c = new Currency(20,40);
//Console.WriteLine("Constractor Answer : "+c);


//Currency c1 = new Currency();
//Console.WriteLine("Method Answer : " + c1);

//Console.WriteLine("Plus : "+(c1 + c1));


//Console.WriteLine("Minus : " + (c1 - c1));

//Console.WriteLine("LessThen : " + (c1 < c1));

//Console.WriteLine("GreaterThen : "+(c1>c1));

//Console.WriteLine("Equal : " + (c1 == c1));

//Console.WriteLine("Not_Equal : " + (c1 != c1));

Bank_Account b = new Bank_Account(101, "Prince", new Currency(100, 0));
Person p = new Person();

Console.WriteLine("\nCustomer Details:");
Console.WriteLine(p);

int choice = 0;

while (choice != 4)
{
    Console.WriteLine("\n1. Deposit");
    Console.WriteLine("2. Withdrawal");
    Console.WriteLine("3. Show");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            b.deposite();
            Console.WriteLine(b);
            break;

        case 2:
            b.withdrawal();
            Console.WriteLine(b);
            break;

        case 3:
            Console.WriteLine(b);
            break;

        case 4:
            Console.WriteLine("Thank You!");
            break;

        default:
            Console.WriteLine("Invalid Choice!");
            break;
    }
}