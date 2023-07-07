using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.CompanyRepositories
{
    public sealed class CompanyCommandRepository : AppDbCommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
