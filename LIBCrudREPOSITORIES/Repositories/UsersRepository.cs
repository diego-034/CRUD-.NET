using LIBCrudDATA.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace LIBCrudREPOSITORIES.Repositories
{
    public class UsersRepository
    {
        public Exception Exception { get; set; }

        public bool Add(Users user)
        {
            try
            {            
                var connection = new SqlConnection(ConfigurationManager.AppSettings["StringConnection"]);
                connection.Open();
                var query = "INSERT INTO Users (name, password," +
                    " state, document)" +
                    " VALUES (@name, @password, @state, @document);";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@state", user.State);
                command.Parameters.AddWithValue("@document", user.Document);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Exception = ex;
                return false;
            }
        }

        public List<Users> List()
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.AppSettings["StringConnection"]);
                connection.Open();

                var query = "SELECT * FROM Users;";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                var dataAdapter = new SqlDataAdapter(command);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                var list = new List<Users>();
                foreach (var item in dataSet.Tables[0].AsEnumerable())
                {
                    list.Add(new Users()
                    {
                        Id = Convert.ToInt32(item.ItemArray[0]),
                        Name = item.ItemArray[1].ToString(),
                        Password = item.ItemArray[2].ToString(),
                        State = Convert.ToInt32(item.ItemArray[3]) == 1 ? true : false,
                        Document = item.ItemArray[4].ToString()
                    });
                }
                connection.Close();
                return list;
            }
            catch(Exception ex)
            {
                Exception = ex;
                return null;
            }
        }

        public bool Update(Users user)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.AppSettings["StringConnection"]);
                connection.Open();
                var query = "UPDATE Users SET name=@name, password=@password," +
                    " state=@state, document=@document" +
                    " WHERE id=@id;";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@state", user.State);
                command.Parameters.AddWithValue("@document", user.Document);
                command.Parameters.AddWithValue("@id", user.Id);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch(Exception ex)
            {
                Exception = ex;
                return false;
            }
        }

        public bool Delete(string userId)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.AppSettings["StringConnection"]);
                connection.Open();
                var query = "DELETE from Users WHERE id=@id;";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", userId);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch(Exception ex)
            {
                Exception = ex;
                return false;
            }
        }

        public List<Users> GetUser(string idSelected)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.AppSettings["StringConnection"]);
                connection.Open();

                var query = "SELECT * FROM Users WHERE id = @idSelected;";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idSelected", idSelected);
                var dataAdapter = new SqlDataAdapter(command);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                var userSelected = new List<Users>();
                foreach (var item in dataSet.Tables[0].AsEnumerable())
                {
                    userSelected.Add(new Users()
                    {
                        Id = Convert.ToInt32(item.ItemArray[0]),
                        Name = item.ItemArray[1].ToString(),
                        Password = item.ItemArray[2].ToString(),
                        State = Convert.ToInt32(item.ItemArray[3]) == 1 ? true : false,
                        Document = item.ItemArray[4].ToString()
                    });
                }
                connection.Close();
                return userSelected;
            }
            catch (Exception ex)
            {
                Exception = ex;
                return null;
            }
        }
    }
}
