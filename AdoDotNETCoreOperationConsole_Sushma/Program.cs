//using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AdoDotNETCoreOperationConsole_Sushma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Server=DESKTOP-GQJ50NH\\SQLSERVER2022;Database=EmployeeDb;User Id=sa;Password=user123;Trusted_Connection=True;" + "TrustServerCertificate=True;";
                Console.WriteLine("Connection successful");
                //calling GetAlleMPLOYESS
                GetallEmployees(connectionString);
                //calling GetEmployeeByID
                int Employeeid = 100;
                GetallEmployeeId(connectionString, Employeeid);
                //calling CreateEmployeeWithAddress 
                string firstName = "sushma";
                string lastName = "MANU";
                string email = "sushma@gmail.com";
                string street = "123 sushma";
                string city = "hyd";
                string state = "india";
                string postalCode = "739237";
                CreateEmployeeWithAddresses(connectionString, firstName, lastName, email, street, city, state, postalCode);
                //calling UpdateEmployeeWithAddress
                int employeeID = 3;
                firstName = "sushma";
                lastName = "chandu";
                email = "sushmanethula@gmail.com";
                street = "3456 patia";
                city = "bng";
                state = "indial";
                postalCode = "8634";
                int addressID = 3;
                UpdateEmployeeWithAddress(connectionString, employeeID, firstName, lastName, email, street, city, state, postalCode, addressID);

                //calling
                employeeID = 3;
                DeleteEmployee(connectionString, employeeID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"something went wrong:{ex.Message}");
            }
        }
        static void GetallEmployees(string connectionString)
        {
            Console.WriteLine("GetAllEmployees Stored Procedure Called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetallEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeID:{reader["EmployeeID"]},FirstName: {reader["FirstName"]},LastName: {reader["LastName"]}, Email: {reader["Email"]}");
                    Console.WriteLine($"Address:{reader["Street"]},{reader["City"]},{reader["States"]},PostalCode:{reader["PostalCode"]}\n ");

                }
                reader.Close();
                connection.Close();
            }
        }
        static void GetallEmployeeId(string connectionString, int Employeeid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeeByID stored procedure called");
                SqlCommand command = new SqlCommand("GetallEmployeeId", connection);
                command.CommandType = CommandType.StoredProcedure;
                //add parameter for EmployeeID
                command.Parameters.AddWithValue("@EmployeeID", Employeeid);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Employee:{reader["FirstName"]} {reader["LastName"]},Email:{reader["Email"]}");
                    Console.WriteLine($"Address:{reader["Street"]},{reader["City"]},{reader["States"]},{reader["postalCode"]}");
                }
                reader.Close();
                connection.Close();
            }
        }
       
        static void CreateEmployeeWithAddresses(string connectionString, string firstName, string lastName, string email, string street, string city, string state, string postalCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Create EmployeeWithAddress stored procedure calles");
                SqlCommand command = new SqlCommand("CreateEmployeeWithAddresses", connection);
                command.CommandType = CommandType.StoredProcedure;
                //Add parameters for employee and adrees
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);

                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@states", state);

                command.Parameters.AddWithValue("@PostalCode", postalCode);

                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Address created successfully..");
                connection.Close();

            }
        }
        static void UpdateEmployeeWithAddress(string connectionString, int employeeID, string firstName, string lastName, string email, string street ,string city,string state ,string postalCode, int addressID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("UpdateEmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                //add parameters foremployee and address
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@States",state);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@addressID", addressID);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Addresses Updated Successfully..");
                connection.Close();

            }

        }
        static void DeleteEmployee(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Delete Employee stored procedure called");
                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                //add paramenters for employee id
                command.Parameters.AddWithValue("@EmployeeId", employeeID);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Employee and their address deleted successfully..");

                }
                else
                {
                    Console.WriteLine("Employee not found");
                }
                connection.Close();
            }
        }
    }
}

