using System;

public class Bank_Account
{
	//create, deposit, withdraw,show
	//Save
	//date 
	Currency zero = new Currency(0, 0);
	int account_no;
	string customer_name;
	Currency balance;
	
	public Bank_Account(int account_no, string customer_name, Currency balance)
	{
		this.account_no = account_no;
		this.customer_name = customer_name;
		this.balance = balance;
	}

	public void deposite()
	{
		Currency amount;
		Console.WriteLine("Enter the Deposite ! ");
		amount = new Currency();

		if(amount>zero)
		{
			balance = balance + amount;
		}
		else
		{
			Console.Write("Not Deposite Rupees !");
		}
	}

    public void withdrawal()
    {
        Currency amount;

        Console.WriteLine("Enter the Withdrawal ! ");
        amount = new Currency();

        if (amount > zero && balance >= amount)
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawal Successful!");
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }
    public void show()
	{

	}
    public override string ToString()
    {
        return "Account No: " + account_no + "\nCustomer Name: " + customer_name + "\nBalance: " + balance;
    }

}
