using FirebirdSql.Data.FirebirdClient;
using System;

namespace EMRepository
{
    public class FireBirdDataBase
    {
        private static string pUser = "SYSDBA";
        private static string pPassword = "masterkey";
        private static string pDatabase = "localhost:C:\\Users\\Suporte\\Documents\\Projetos\\BancoEmProject";
        private static string pDataSource = "localhost";
        private static int pPort = 3054;
        private static int pDialet = 3;
        private static string pCharset = FbCharset.Utf8.ToString();

        public FbConnection connection;

        public bool bconexao { get; set; }

        public FireBirdDataBase()
        {
            FbConnectionStringBuilder stringconnection = new FbConnectionStringBuilder()
            {
                Port = pPort,
                UserID = pUser,
                Password = pPassword,
                Database = pDatabase,
                Dialect = pDialet,
                Charset = pCharset
            };

            try
            {
                connection = new FbConnection(stringconnection.ToString());
                connection.Open();
                bconexao = true;
            }
            catch (Exception ex)
            {
                bconexao = false;
            }
        }
    }
}
