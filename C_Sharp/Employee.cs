using System;

public class Employee : Person
{
	string post;
	int salary;

	public Employee()
	{
		Console.Write("Enter the Post : ");
		this.post = Console.ReadLine();

		Console.Write("Enter the Salary : ");
		this.salary = Convert.ToInt32(Console.ReadLine());

	}

    public override string ToString()
    {
		return base.ToString()+"\nPost" + post + "\nSalary : " + salary;
    }
}
