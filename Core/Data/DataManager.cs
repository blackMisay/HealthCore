using System.Data;
using MySqlConnector;

namespace Core.Data
{
    internal class DataManager
    {
        private MySqlConnection connection = new();
        private string errorMesage = "";
        private readonly string connectionString;
        private int lastInsertedId = 0;


        /// <summary>
        /// This constructor initializes the DataManager object with default connection parameters.
        /// </summary>
        /// <returns>None</returns>
        public DataManager()
        {
            string[] connectionParameters =
            {
                "localhost",
                "healthcore",
                "root",
                ""
            };

            this.connectionString = String.Format("server={0};database={1};userid={2};password={3};",
                connectionParameters[0], connectionParameters[1], connectionParameters[2], connectionParameters[3]);
            this.Open();
        }


        /// <summary>
        /// This constructor allows the user to specify a custom connection string.
        /// </summary>
        /// <param name="connectionString">String represents the connection string</param>
        /// <returns>None</returns>
        public DataManager(string connectionString)
        {
            this.connectionString = connectionString;
            this.Open();
        }


        /// <summary>
        /// This method is responsible for establishing a connection to the database using the provided connection string
        /// </summary>
        /// <param>None</param>
        /// <returns>None</returns>
        /// <exception cref="Exception">It catches any exceptions that occur during the execution of the query and rethrows them with a new exception containing the error message.</exception>
        private protected void Open()
        {
            try
            {
                connection = new(connectionString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                // Log or handle specific MySql errors here
                throw new Exception($"Error executing query: {ex.Message}");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }


        /// <summary>
        /// This method executes a parameterized query and returns a boolean result if the query succeeds.
        /// </summary>
        /// <param name="query">A string representing the SQL query to execute.</param>
        /// <param name="parameters">A dictionary containing parameter names and their corresponding values.</param>
        /// <param name="isScalar">A boolean representing if the query should return the first column of the first row in the result set. Default value is false</param>>
        /// <returns>True if the query execution is successful, otherwise false.</returns>
        /// <exception cref="Exception">It catches any exceptions that occur during the execution of the query and rethrows them with a new exception containing the error message.</exception>
        public bool Execute(string query, Dictionary<string, string> parameters, bool isScalar = false)
        {
            try
            {
                query = isScalar ? String.Concat(query, "SELECT LAST_INSERT_ID();") : query;

                using (MySqlCommand cmd = new MySqlCommand(query, this.connection))
                {
                    foreach (KeyValuePair<string, string> kvp in parameters)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    if (isScalar)
                    {
                        this.lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (MySqlException dbException)
            {
                // Log or handle specific MySql errors here
                this.errorMesage = dbException.Message.ToString();
            }
            catch (Exception ex)
            {
                this.errorMesage = ex.Message.ToString();
            }
            return false;
        }


        /// <summary>
        /// This method executes a query against the database and returns the result in the form of a DataTable
        /// </summary>
        /// <param name="query">A string representing the SQL query to execute.</param>
        /// <returns>It returns the populated <see cref="System.Data.DataTable"/> containing the result of the query.</returns>
        /// <exception cref="Exception">
        /// It catches any exceptions that occur during the execution of the query and rethrows them with
        /// a new exception containing the error message.</exception>
        public DataTable Load(string query)
        {
            return this.Load(query, null);
        }


        /// <summary>
        /// This method executes a parameterized query against the database and returns the result in the form of a DataTable
        /// </summary>
        /// <param name="query">A string representing the SQL query to execute.</param>
        /// <param name="param">A dictionary containing parameter names and their corresponding values.</param>
        /// <returns>It returns the populated <see cref="System.Data.DataTable"/> containing the result of the query.</returns>
        /// <exception cref="Exception">It catches any exceptions that occur during the execution of the query and rethrows them with
        /// a new exception containing the error message.</exception>
        public DataTable Load(string query, Dictionary<string, string>? param)
        {
            DataTable dt = new();
            try
            {
                using (MySqlCommand cmd = new(query, this.connection))
                {
                    if (param != null)
                    {
                        foreach (KeyValuePair<string, string> kvp in param)
                        {
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                        }
                    }
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch (MySqlException dbException)
            {
                // Log or handle specific MySql errors here
                this.errorMesage = dbException.Message.ToString();
            }
            catch (Exception ex)
            {
                this.errorMesage = ex.Message.ToString();
            }
            return dt;
        }


        /// <summary>
        /// Method for closing an open connection.
        /// </summary>
        public void Close()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Method for returning the last inserted id in the table.
        /// </summary>
        /// <returns>Returns the last inserted id as <see cref="System.Int32"/>.</returns>
        public int GetLastInsertedId()
        {
            return this.lastInsertedId;
        }

        
        /// <summary>
        /// Method for returning reported exceptions.
        /// </summary>
        /// <returns>Exception message</returns>
        public string GetErrorMessage()
        {
            return this.errorMesage;
        }
    }
}