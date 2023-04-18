using System.Data.Common;
using MySqlConnector;
namespace TecNM.Ecommerce.Api.DataAccess;
using TecNM.Ecommerce.Api.DataAccess.Interfaces;


public class DbContext:IDbContext{

    private readonly string _connectionString = "server=localhost;user=root;password=luisrull11;database=twm;port=3306";

    private MySqlConnection _connection;

    public DbConnection Connection{
            get{
                if(_connection ==null){
                    _connection = new MySqlConnection(_connectionString);
                }
                return _connection;
            }

    }

}