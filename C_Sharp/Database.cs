using Microsoft.Data.SqlClient;

public class Database
{
    public static string connectionString = "Server=localhost;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public static void TestConnection()
    {
        using SqlConnection con = new SqlConnection(connectionString);

        try
        {
            con.Open();
            Console.WriteLine("SQL Server Connected Successfully!");
        }
        catch (Exception ex)
        {

            Console.WriteLine("Connection Failed!");
            Console.WriteLine(ex.Message);
        }
    }
}