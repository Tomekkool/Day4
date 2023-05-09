using Microsoft.Data.SqlClient;

SqlConnection connection; // stores info about connectiong to DB

SqlCommand command; // stores sql commands

SqlDataReader reader; // reading data from DB

string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VolleyballDatabase;Integrated Security=True;Pooling=False";
connection = new SqlConnection(connectionString);

command = new SqlCommand("select * from Players", connection);

connection.Open();

reader=command.ExecuteReader(); //executes query to database

while (reader.Read())
{
    string result =reader.GetValue(2) + " " + reader.GetValue(3);
    
    Console.WriteLine(result);

}
connection.Close();
