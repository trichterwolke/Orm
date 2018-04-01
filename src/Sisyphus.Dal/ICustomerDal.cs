using Sisyphus.Entities;

namespace Sisyphus.Dal
{
    public interface ICustomerDal : ICrudDal<Customer>
    {
        Customer FindByName(string name);
    }
}