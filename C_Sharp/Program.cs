using Microsoft.Data.SqlClient;
using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Database.TestConnection();

Bank_Account[] bankaccounts = new Bank_Account[10] ;
int accounts = 0;

Console.WriteLine("\nAccount Details:");
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
                using SqlConnection con = new SqlConnection(Database.connectionString);

                con.Open();
                string accountSql=@"SELECT ISNULL(MAX(AccountNo), 0) + 1 FROM Bank_Accounts";

                using SqlCommand accountCmd = new SqlCommand(accountSql, con);
                accounts = Convert.ToInt32(accountCmd.ExecuteScalar());

                Bank_Account b = new Bank_Account("" + accounts);
                bankaccounts[accounts - 1] = b;

                string sql = @" INSERT INTO Bank_Accounts (AccountNo,CustomerName,Mobile,Address,Age,Balance) VALUES (@AccountNo,@CustomerName,@Mobile,@Address,@Age,@Balance)";
                using SqlCommand cmd = new SqlCommand(sql,con);

                cmd.Parameters.AddWithValue("@AccountNo",accounts);
                cmd.Parameters.AddWithValue("@CustomerName",b.Customer.Name);
                cmd.Parameters.AddWithValue("@Mobile",b.Customer.Mobile);
                cmd.Parameters.AddWithValue("@Address",b.Customer.Address);
                cmd.Parameters.AddWithValue("@Age",b.Customer.Age);

                decimal balance=b.Balance.Total/100m;
                cmd.Parameters.AddWithValue("@Balance",balance);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Account saved in database successfully!");
                Console.WriteLine(b);
            }
            break;

        case 2:
            {
                Console.Write("Enter account no: ");
                int accno=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter deposit amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                using SqlConnection con =new SqlConnection(Database.connectionString);

                string sql = @"UPDATE Bank_Accounts SET Balance = Balance + @Amount WHERE AccountNo = @AccountNo";
                using SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@AccountNo", accno);

                con.Open();

                int rows=cmd.ExecuteNonQuery();

                if (rows>0)
                {
                    Console.WriteLine("Deposit successful!");
                }
                else
                {
                    Console.WriteLine("Account not found!");
                }
            }
            break;

        case 3:
            {
                Console.Write("Enter account no: ");
                int accno =Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter withdrawal amount: ");
                decimal amount=Convert.ToDecimal(Console.ReadLine());

                using SqlConnection con=new SqlConnection(Database.connectionString);

                string sql = @"UPDATE Bank_Accounts SET Balance = Balance - @Amount WHERE AccountNo = @AccountNo AND Balance >= @Amount";
                using SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@AccountNo", accno);

                con.Open();
                int rows =cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Withdrawal successful!");
                }
                else
                {
                    Console.WriteLine("Insufficient balance or account not found!");
                }
            }
            break;

        case 4:
            {
                Console.Write("Enter account no: ");
                int accno = Convert.ToInt32(Console.ReadLine());

                using SqlConnection con = new SqlConnection(Database.connectionString);

                string sql = @"SELECT AccountNo, CustomerName, Mobile, Address, Age, Balance FROM Bank_Accounts WHERE AccountNo = @AccountNo";
                using SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@AccountNo", accno);
                con.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Console.WriteLine("\n--- Account Details ---");
                    Console.WriteLine("Account No: " + reader["AccountNo"]);
                    Console.WriteLine("Customer Name: " + reader["CustomerName"]);
                    Console.WriteLine("Mobile: " + reader["Mobile"]);
                    Console.WriteLine("Address: " + reader["Address"]);
                    Console.WriteLine("Age: " + reader["Age"]);
                    Console.WriteLine("Balance: ₹" + reader["Balance"]);
                }
                else
                {
                    Console.WriteLine("Account not found!");
                }
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