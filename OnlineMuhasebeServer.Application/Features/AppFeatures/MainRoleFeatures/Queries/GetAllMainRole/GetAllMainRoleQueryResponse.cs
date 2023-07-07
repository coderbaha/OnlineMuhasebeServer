using OnlineMuhasebeServer.Domain.AppEntities;
using System.Collections.Generic;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole
{
    public sealed record GetAllMainRoleQueryResponse(IList<MainRole> MainRoles);
}
