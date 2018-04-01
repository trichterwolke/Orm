namespace Sisyphus.Dal.SQLite
{
    using Dapper;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;

    public class SQLiteConnectionFactory : IDbConnectionFactory
    {
        static SQLiteConnectionFactory()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;            
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
        }

        private readonly string connectionStirng;

        public SQLiteConnectionFactory(string path)
        {
            var file = new FileInfo(path);
            if(!file.Exists)
            {
                throw new FileNotFoundException($"File {path} not found.");
            }

            this.connectionStirng = "Data Source=" + path;
        }

        public IDbConnection Create()
        {
            return new SQLiteConnection(connectionStirng);
        }
    }
}
