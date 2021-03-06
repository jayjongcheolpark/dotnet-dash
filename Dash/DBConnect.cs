﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    public class DBConnect
    {
        private MySqlConnection _connection = null;
        private string _server;
        private string _database, _uid, _password;
        private MySqlCommand _verifyCM, _useraddCM, _userdelCM, _userupdateCM, _userpasswdCM,
            _employeeCM;

        public DBConnect(string database, string uid, string password)
        {
            this._database = database.Trim();
            this._uid = uid.Trim();
            this._password = password.Trim();
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
                mySqlConnectionStringBuilder.Server = "142.55.32.48";
                mySqlConnectionStringBuilder.Port = 3306;
                mySqlConnectionStringBuilder.Database = _database;
                mySqlConnectionStringBuilder.UserID = _uid;
                mySqlConnectionStringBuilder.Password = _password;
                
                _connection = new MySqlConnection(mySqlConnectionStringBuilder.ConnectionString);
                _connection.Open();
                try
                {
                    //User commands
                    _verifyCM = new MySqlCommand();
                    _verifyCM.Connection = _connection;
                    _verifyCM.CommandText = "SELECT id, name, city, phone, email, birthdate, employee FROM users WHERE username=@val1 AND password=@val2 LIMIT 1";
                    _verifyCM.Prepare();

                    _useraddCM = new MySqlCommand();
                    _useraddCM.Connection = _connection;
                    _useraddCM.CommandText = "INSERT INTO users (name, email, password) VALUES (@val1, @val2, @val3)";
                    _useraddCM.Prepare();

                    _userdelCM = new MySqlCommand();
                    _userdelCM.Connection = _connection;
                    _userdelCM.CommandText = "DELETE FROM users WHERE id=@val1";
                    _userdelCM.Prepare();

                    _userupdateCM = new MySqlCommand();
                    _userupdateCM.Connection = _connection;
                    _userupdateCM.CommandText = "UPDATE users SET email=@val1, name=@val2 WHERE id=@val3";
                    _userupdateCM.Prepare();

                    //Employee commands
                    _employeeCM = new MySqlCommand();
                    _employeeCM.Connection = _connection;
                    _employeeCM.CommandText = "SELECT * FROM employee WHERE empID=@empID";
                    _employeeCM.Prepare();

                    return true;
                }catch(MySqlException ex){
                    try
                    {
                        _connection.Close();
                    }catch(MySqlException ex2)
                    {
                        throw new Exception("Cannot close connection to the database: " + ex);
                    }
                    throw new Exception("Cannot create prepared statement: "+ex);
                }
                
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception("Cannot connect to server.  Contact administrator");

                    case 1045:
                        throw new Exception("Invalid username/password, please try again");
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //return false;
                throw new Exception(ex.Message);
                
            }
        }

        //User verification
        public User verifyUser(string username, string password)
        {
            User user = null;
            try
            {
                if (_verifyCM.Parameters.Count > 0)
                {
                    _verifyCM.Parameters[0].Value = username;
                    _verifyCM.Parameters[1].Value = password;
                }
                else
                {
                    _verifyCM.Parameters.AddWithValue("@val1", username);
                    _verifyCM.Parameters.AddWithValue("@val2", password);
                }
                MySqlDataReader reader = _verifyCM.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = new User(reader.GetInt32("id"),
                            reader.GetString("name"),
                            username,
                            reader.GetString("city"),
                            reader.GetString("phone"),
                            reader.GetString("email"),
                            reader.GetString("birthdate"),
                            reader.GetInt32("employee"));
                    }
                }
                reader.Close();
                user.JobInfo = GetEmployeeByID(user.EmployeeID);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Could not verify user: " + ex);
            }
            return user;
        }

        public Employee GetEmployeeByID(int id)
        {
            Employee employee = null;
            try
            {
                if (_employeeCM.Parameters.Count > 0)
                {
                    _employeeCM.Parameters[0].Value = id;
                }
                else
                {
                    _employeeCM.Parameters.AddWithValue("@empID", id);
                }
                MySqlDataReader reader = _employeeCM.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employee = new Employee(reader.GetInt32("empID"),
                            reader.GetString("empName"),
                            reader.GetString("empHireDate"),
                            reader.GetDecimal("empSalary"),
                            reader.GetString("empPhone"),
                            reader.GetInt32("empPosition"),
                            reader.GetInt32("empDepartment"));
                    }
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Could not get employee: " + ex.Message);
            }
            return employee;
        }
    }
}
