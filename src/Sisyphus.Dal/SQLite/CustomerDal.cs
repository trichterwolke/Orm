namespace Sisyphus.Dal.SQLite
{
    using Dapper;
    using Sisyphus.Entities;
    using System.Collections.Generic;

    public class CustomerDal : CrudDalBase<Customer>, ICustomerDal
    {
        public CustomerDal(IDbConnectionFactory connectionFactory)
            : base(connectionFactory)
        {
        }

        public Customer FindByName(string name)
        {
            using (var connection = ConnectionFactory.Create())
            {
                return connection.QuerySingleOrDefault<Customer>("SELECT * FROM Customer WHERE Name = @name", new { name });
            }
        }
    }
}