//NOTE: test connection

using System.Data.SQLite;

string stm = "SELECT SQLITE_VERSION()";

using var con = new SQLiteConnection("Data Source=:memory:");
con.Open();

using SQLiteCommand cmd = con.CreateCommand();
cmd.CommandText = stm;
object obj = cmd.ExecuteScalar();
string version = obj.ToString();
Console.WriteLine($"SQLite version: {version}");

con.Close();




//NOTE: write data

//using System.Data.SQLite;

//string cs = @"URI=file:fruits.db";
//using var con = new SQLiteConnection(cs);
//con.Open();

//using var cmd = new SQLiteCommand(con);
//cmd.CommandText = @"CREATE TABLE IF NOT EXISTS fruits(id INTEGER PRIMARY KEY, name TEXT, price INT)";
//cmd.ExecuteNonQuery();

//cmd.CommandText = "INSERT INTO fruits(name, price) VALUES('Apple', 123)";
//cmd.ExecuteNonQuery();
//cmd.CommandText = "INSERT INTO fruits(name, price) VALUES('Orange', 234)";
//cmd.ExecuteNonQuery();

//con.Close();




//NOTE: read data

//using System.Data.SQLite;

//string cs = @"URI=file:fruits.db";
//using var con = new SQLiteConnection(cs);
//con.Open();

//string stm = "SELECT * FROM fruits LIMIT 50";

//using var cmd = new SQLiteCommand(stm, con);
//using SQLiteDataReader rdr = cmd.ExecuteReader();

//while (rdr.Read())
//{
//    Console.WriteLine($"{rdr.GetInt32(0)}. {rdr.GetString(1)}:\t{rdr.GetInt32(2)}");
//}

//con.Close();