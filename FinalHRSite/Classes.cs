using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordController;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FinalHRSite
{
    internal static class Classes
    {
        //Gets the data from the table and returns it as a DataTable
        public static DataTable SqlTableGetter(string table, string selected)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT {selected} FROM {table}", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        //Overload for the SqlTableGetter method that allows for a WHERE clause
        public static DataTable SqlTableGetter(string table, string selected, string constraint, string where)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT {selected} FROM {table} WHERE {constraint} = {where}", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        //Add a new row to the table EMPLOYEES
        public static void SqlDataAdder(string values)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                int id;
                SqlCommand eid = new SqlCommand("SELECT MAX(EMPLOYEE_ID) FROM EMPLOYEES", connection);
                connection.Open();
                id = (int)eid.ExecuteScalar() + 1;
                string query = $"INSERT INTO EMPLOYEES VALUES ({id},{values})";
                SqlCommand command = new SqlCommand($"INSERT INTO EMPLOYEES VALUES ({id},{values})", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //Data Adder for the PTO table
        public static void SqlDataAdderPTO(string values)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO PTO VALUES ({values})", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //Gets data from the table and returns it as a string array
        public static string[] SqlDataGetter(string table, string selected)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                List<string> data = new List<string>();
                SqlCommand command = new SqlCommand($"SELECT {selected} FROM {table}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(reader.GetString(0));
                }
                connection.Close();
                return data.ToArray();
            }
        }
        //Overload for the SqlDataGetter method that allows for a WHERE clause
        public static string[] SqlDataGetter(string table, string selected, string where, string modifier)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                List<string> data = new List<string>();
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand($"SELECT {selected} FROM {table} WHERE {where} = {modifier}", connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        data.Add(row[column].ToString());
                    }
                }
                connection.Close();
                return data.ToArray();
            }
        }
        //Creates a new user in the LOGIN table
        public static void PasswordMaker(string username, string password, int id, int access)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                string hash = null;
                byte[] salt = null;
                PasswordSalt passwordSalt = new PasswordSalt();
                hash = passwordSalt.HashPassword(password, out salt);
                string newSalt = Convert.ToBase64String(salt);
                SqlCommand command = new SqlCommand($"INSERT INTO LOGIN VALUES ('{username}', '{hash}', '{newSalt}',{id},{access})", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //Update password
        public static void PasswordUpdate(string newPass, string id)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                string hash = null;
                byte[] salt = null;
                PasswordSalt passwordSalt = new PasswordSalt();
                hash = passwordSalt.HashPassword(newPass, out salt);
                string newSalt = Convert.ToBase64String(salt);
                SqlCommand command = new SqlCommand($"UPDATE LOGIN SET HASH = '{hash}', Salt = '{newSalt}' WHERE Username = '{id}'", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //Update SQL Entries
        public static void Updater(string table, string set, string value, string where, string value2)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                SqlCommand command = new SqlCommand($"UPDATE {table} SET {set} = '{value}' WHERE {where} = {value2}", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
