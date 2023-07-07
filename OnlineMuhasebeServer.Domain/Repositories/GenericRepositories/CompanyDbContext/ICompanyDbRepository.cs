using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories;

namespace OnlineMuhasebeServer.Domain.Repositories
{
    public interface ICompanyDbRepository<T>: IRepository<T>
        where T : Entity
    {
        void SetDbContextInstance(DbContext context);
    }
}
