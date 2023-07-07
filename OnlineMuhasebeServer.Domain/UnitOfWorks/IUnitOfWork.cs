using System.Threading;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Domain.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
