using Microsoft.Extensions.Configuration;

namespace Data.Factory
{
    public abstract class AbstractRepository
    {
        private string _connectionString;
        protected string ConnectionString => _connectionString;

        public AbstractRepository(IConfiguration configuration){
            _connectionString = configuration.GetValue<string>("Server=C:\\Users\\Suporte\\Documents\\Projetos\\BancoEmProject\\BDVAZIO.FB4,3054;Database=BDVAZIO.FB4;User Id=SYSDBA;Password=masterkey;");    
        }
    }
}