﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Administrator
{
    internal class WatchupongConnections
    {
       
            // Static instance of the connection
            private static WatchupongConnections _instance;
            private static readonly object _lock = new object(); // Ensures thread safety

            // SqlConnection and SqlCommand fields
            private SqlConnection _sqlcon;
            private SqlCommand _sqlcom;

            // Connection string (you can change this to your actual connection string)
            private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ikawparin\\source\\repos\\AquaPrime_Project_Application\\watchupong\\AdminSide\\Database.mdf;Integrated Security=True";

            // Private constructor to prevent external instantiation
            private WatchupongConnections()
            {
                _sqlcon = new SqlConnection(_connectionString);
            }

            // Public method to get the single instance of the connection class
            public static WatchupongConnections Instance
            {
                get
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new WatchupongConnections();
                        }
                        return _instance;
                    }
                }
            }

            // Public method to open the connection
            public void Open()
            {
                if (_sqlcon.State == System.Data.ConnectionState.Closed)
                {
                    _sqlcon.Open();
                }
            }

            // Public method to close the connection
            public void Close()
            {
                if (_sqlcon.State == System.Data.ConnectionState.Open)
                {
                    _sqlcon.Close();
                }
            }

            // Method to create a SqlCommand with the current connection
            public SqlCommand CreateCommand(string query)
            {
                Open();
                _sqlcom = new SqlCommand(query, _sqlcon);
                return _sqlcom;
            }
            public SqlDataReader ExecuteReader(string query)
            {
                Open(); // Ensure the connection is open
                _sqlcom = new SqlCommand(query, _sqlcon);

                try
                {
                    // Execute the query and return the SqlDataReader
                    return _sqlcom.ExecuteReader();
                }
                finally
                {
                    // Close the command regardless of exceptions (recommended practice)
                    _sqlcom.Dispose();
                }
            }

            // Property to access the connection directly, if needed
        }

    }

