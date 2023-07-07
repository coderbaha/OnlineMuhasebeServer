using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

public class UserAndCompanyRelationshipQueryRepository : AppQueryRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipQueryRepository
{
    public UserAndCompanyRelationshipQueryRepository(Context.AppDbContext context) : base(context) { }
}
