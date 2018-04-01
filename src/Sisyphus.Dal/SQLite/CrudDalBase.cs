namespace Sisyphus.Dal.SQLite
{
    using Dapper;
    using System.Collections.Generic;

    public abstract class CrudDalBase<T> : ICrudDal<T>
    {
        private IDbConnectionFactory connectionFactory;
        private static readonly string FindByIDCommandText = ("SELECT * FROM " + typeof(T).Name + " WHERE id=@id").ToLower();
        private static readonly string FindByAllCommandText = ("SELECT * FROM " + typeof(T).Name).ToLower();
        private static readonly string DeleleCommandText = ("DELETE FROM " + typeof(T).Name + " WHERE id=@id").ToLower();

        public CrudDalBase(IDbConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public IDbConnectionFactory ConnectionFactory => this.connectionFactory;

        public T FindByID(int id)
        {
            using (var connection = this.connectionFactory.Create())
            {
                return connection.QueryFirstOrDefault<T>(FindByIDCommandText, new { id });
            }
        }

        public IEnumerable<T> FindAll()
        {
            using (var connection = this.connectionFactory.Create())
            {
                return connection.Query<T>(FindByAllCommandText);
            }
        }

        public int? Insert(T entity)
        {
            using (var connection = this.connectionFactory.Create())
            {
                return connection.Insert(entity);
            }
        }

        public void Update(T entity)
        {
            using (var connection = this.connectionFactory.Create())
            {
                connection.Update(entity);
            }
        }

        public void Delete(int id)
        {
            using (var connciton = this.connectionFactory.Create())
            {
                connciton.Execute(DeleleCommandText, new { id });
            }
        }
    }
}
