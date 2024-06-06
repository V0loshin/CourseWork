using MySql.Data.MySqlClient;

namespace WebApp
{
    public class DataBase
    {
        MySqlConnection _connection = new MySqlConnection("server=localhost;port=3306;username=root;password=Bk.[fDjkj[f03;database=institutes");

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
