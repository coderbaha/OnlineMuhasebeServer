using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using System.Collections.Generic;

namespace OnlineMuhasebeServer.Application.Features.RoleFeatures.Queries.GetAllRoles
{
    public sealed record GetAllRolesQueryResponse(IList<AppRole> Roles);
}
