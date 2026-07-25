using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString =
        "Data Source=localhost;Initial Catalog=EmployeeDB;Integrated Security=True;TrustServerCertificate=True";

    static void Main(string[] args)
    {
        InsertEmployee(101, "Tarun", 50000);
        ReadEmployees();

        UpdateEmployee(101, 55000);
        ReadEmployees();

        DeleteEmployee(101);
        ReadEmployees();
    }

    static void InsertEmployee(int id, string name, decimal salary)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query =
                "INSERT INTO Employees(Id, Name, Salary) VALUES(@Id, @Name, @Salary)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Salary", salary);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Inserted Successfully");
        }
    }

    static void ReadEmployees()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Employees";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nEmployee Records:");

            while (reader.Read())
            {
                Console.WriteLine(
                    $"Id: {reader["Id"]}, Name: {reader["Name"]}, Salary: {reader["Salary"]}");
            }
        }
    }

    static void UpdateEmployee(int id, decimal salary)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query =
                "UPDATE Employees SET Salary=@Salary WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Salary", salary);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("\nEmployee Updated Successfully");
        }
    }

    static void DeleteEmployee(int id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query =
                "DELETE FROM Employees WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("\nEmployee Deleted Successfully");
        }
    }
}