using System.Data;

namespace Sisyphus.Dal
{
    public interface IDbConnectionFactory
    {
        IDbConnection Create();
    }
}