using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppServices;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole
{
    public sealed class GetAllMainRoleQueryHandler : IQueryHandler<GetAllMainRoleQuery, GetAllMainRoleQueryResponse>
    {
        private readonly IMainRoleService _mainRoleService;
        public GetAllMainRoleQueryHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }
        public async Task<GetAllMainRoleQueryResponse> Handle(GetAllMainRoleQuery request, CancellationToken cancellationToken)
        {
            var result = _mainRoleService.GetAll();
            return new GetAllMainRoleQueryResponse(await result.ToListAsync());
        }
    }
}
