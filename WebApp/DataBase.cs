using MySql.Data.MySqlClient;

namespace WebApp
{
    // Класс для подключения к базе данных
    public class DataBase
    {
        MySqlConnection _connection = new MySqlConnection("server=localhost;port=3306;username=;password=;database=institutes");

        public void openConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed) { _connection.Open(); }
        }

        public void closeConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open) { _connection.Close(); }
        }

        public MySqlConnection getConnection()
        {
            return _connection;
        }
    }
}
