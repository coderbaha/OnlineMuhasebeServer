using OnlineMuhasebeServer.Domain.AppEntities;
using System.Collections.Generic;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany
{
    public sealed record GetAllCompanyQueryResponse(List<Company> Companies);
}
