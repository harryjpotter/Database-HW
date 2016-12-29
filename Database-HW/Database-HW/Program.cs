using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rotem_000\\Documents\\GitHub\\Database-HW\\Database-HW\\Database-HW\\Songs.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            SqlCommand create_table_command = new SqlCommand();
            create_table_command.Connection = conn;
            create_table_command.CommandText = "CREATE TABLE songs (singer varchar(255), name varchar(255), year int);";
            create_table_command.ExecuteNonQuery();
            

            SqlCommand insert_into_command = new SqlCommand();
            insert_into_command.Connection = conn;
            insert_into_command.CommandText = "INSERT INTO songs VALUES ('Nicky Jam y Enrique Iglesias', 'El perdón', 2015);";
            insert_into_command.ExecuteNonQuery();


            SqlCommand insert_into_command1 = new SqlCommand();
            insert_into_command1.Connection = conn;
            insert_into_command1.CommandText = "INSERT INTO songs VALUES ('Enrique Iglesias', 'Bailando', 2014);";
            insert_into_command1.ExecuteNonQuery();

            SqlCommand insert_into_command2 = new SqlCommand();
            insert_into_command2.Connection = conn;
            insert_into_command2.CommandText = "INSERT INTO songs VALUES ('Enrique Iglesias', 'Duele el corazón', 2016);";
            insert_into_command2.ExecuteNonQuery();

            SqlCommand insert_into_command3 = new SqlCommand();
            insert_into_command3.Connection = conn;
            insert_into_command3.CommandText = "INSERT INTO songs VALUES ('lali esposito', 'Quiero gritarte que te quiero', 2015);";
            insert_into_command3.ExecuteNonQuery();

            SqlCommand select_command = new SqlCommand();
            select_command.Connection = conn;
            select_command.CommandText = "SELECT * FROM songs;";
            SqlDataReader reader = select_command.ExecuteReader();
            while(reader.Read())
            {
                Console.Write("{0} : {1}, ", reader.GetName(0),reader.GetString(0));
                Console.Write("{0} : {1}, ", reader.GetName(1), reader.GetString(1));
                Console.Write("{0} : {1}, " + "\n", reader.GetName(2), reader.GetInt32(2));
            }
            conn.Close();
        }
    }
}
