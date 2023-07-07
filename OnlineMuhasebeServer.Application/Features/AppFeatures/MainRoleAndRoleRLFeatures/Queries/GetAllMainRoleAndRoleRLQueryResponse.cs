using OnlineMuhasebeServer.Domain.AppEntities;
using System.Collections.Generic;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries;

public sealed record GetAllMainRoleAndRoleRLQueryResponse(
    List<MainRoleAndRoleRelationship> mainRoleAndRoleRelationships);
