using System;

public class Validation
{
    public static int GetPositiveInt(string message)
    {
        int value;

        while (true)
        {
            Console.Write(message);
            value = Convert.ToInt32(Console.ReadLine());

            if (value >= 0)
            {
                return value;
            }

            Console.WriteLine("Value negative nahi ho sakti!");
        }
    }

    public static int GetPositiveAccountNo(string message, int totalAccounts)
    {
        int value;

        while (true)
        {
            Console.Write(message);
            value = Convert.ToInt32(Console.ReadLine());

            if (value >= 1 && value <= totalAccounts)
            {
                return value;
            }

            Console.WriteLine("Invalid Account Number!");
        }
    }
}