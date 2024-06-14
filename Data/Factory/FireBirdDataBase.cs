using FirebirdSql.Data.FirebirdClient;

namespace Data
{
    public class FireBirdDataBase
    {
        private readonly string _connectionString;

        public FireBirdDataBase(string connectionString)
        {
            _connectionString = connectionString;
        }

        public FbConnection CreateConneciton( ){
            return new FbConnection(_connectionString);
        }
    }
}