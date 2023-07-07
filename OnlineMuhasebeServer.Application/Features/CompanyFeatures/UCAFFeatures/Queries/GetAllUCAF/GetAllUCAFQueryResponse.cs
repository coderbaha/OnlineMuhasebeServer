using OnlineMuhasebeServer.Domain.CompanyEntities;
using System.Collections.Generic;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Queries.GetAllUCAF;

public sealed record GetAllUCAFQueryResponse(IList<UniformChartOfAccount> Data);
