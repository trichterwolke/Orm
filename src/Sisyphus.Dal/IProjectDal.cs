namespace Sisyphus.Dal
{
    using Sisyphus.Entities;
    using System.Collections.Generic;

    public interface IProjectDal : ICrudDal<Project>
    {
        Project FindByName(string name);

        IEnumerable<Project> FindByCustomer(int? customerID);
    }
}