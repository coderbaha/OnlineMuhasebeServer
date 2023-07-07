using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

public class MainRoleAndUserRelationshipCommandRepository : AppDbCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipCommandRepository
{
    public MainRoleAndUserRelationshipCommandRepository(Context.AppDbContext context) : base(context) { }
}