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

Bank_Account[] bankaccounts = new Bank_Account[10] ;
int accounts = 0;

//Employee e = new Employee();
Console.WriteLine("\nAccount Details:");
//Console.WriteLine(b);

int choice = 0;

while (true)
{
    Console.WriteLine("\n1. New Account");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdrawal");
    Console.WriteLine("4. Show");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                accounts++;
                Bank_Account b = new Bank_Account("" + accounts);
                bankaccounts[accounts-1] =b;
                Console.WriteLine(b);
                }
                break;
            case 2:
                { 
                Console.WriteLine("Enter account no");
                int accno = Convert.ToInt32(Console.ReadLine());
                Bank_Account b = bankaccounts[accno - 1];
                b.deposite();
                Console.WriteLine(b);
                }
                break;

            case 3:
                {
                    Console.WriteLine("Enter account no");
                    int accno = Convert.ToInt32(Console.ReadLine());
                    Bank_Account b = bankaccounts[accno - 1];
                    b.withdrawal();
                    Console.WriteLine(b);
                }
                break;

            case 4:
                {
                    Console.WriteLine("Enter account no");
                    int accno = Convert.ToInt32(Console.ReadLine());
                    Bank_Account b = bankaccounts[accno - 1];
                    Console.WriteLine(b);
                }
                break;

            case 0:
                Console.WriteLine("Thank You!");
            return;
             

            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    } 