namespace Sisyphus.Dal.SQLite
{
    using Dapper;
    using Sisyphus.Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class ProjectDal : CrudDalBase<Project>, IProjectDal
    {
        public ProjectDal(IDbConnectionFactory connectionFactory)
            : base(connectionFactory)
        {
        }

        public Project FindByName(string name)
        {

            const string FindByNameCommandText =
                @"SELECT p.id, p.name, c.id, c.name 
                FROM project p
                INNER JOIN customer c on c.id = p.customer_id";

            using (var connection = ConnectionFactory.Create())
            {
                return connection.Query<Project, Customer, Project>(
                    FindByNameCommandText,
                    (p, c) =>
                    {
                        p.Customer = c;
                        return p;
                    }, "name").FirstOrDefault();

            }
        }

        public IEnumerable<Project> FindByCustomer(int? customerID)
        {
            const string FindByNameCommandText =
                @"SELECT p.id, p.name, c.id, c.name 
                FROM project p
                INNER JOIN customer c on c.id = p.customer_id";

            using (var connection = ConnectionFactory.Create())
            {
                return connection.Query<Project, Customer, Project>(
                    FindByNameCommandText,
                    (p, c) =>
                    {
                        p.Customer = c;
                        return p;
                    }, "name");

            }
        }
    }
}
