using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.Roles;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.RoleFeatures.Commands.CreateStaticRoles
{
    public sealed class CreateStaticRolesCommandHandler : ICommandHandler<CreateStaticRolesCommand, CreateStaticRolesCommandResponse>
    {
        private readonly IRoleService _roleService;
        public CreateStaticRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public async Task<CreateStaticRolesCommandResponse> Handle(CreateStaticRolesCommand request, CancellationToken cancellationToken)
        {
            IList<AppRole> originalRoleList = RoleList.GetStaticRoles();
            IList<AppRole> newRoleList = new List<AppRole>();
            foreach (AppRole role in originalRoleList)
            {
                AppRole checkRole = await _roleService.GetByCode(role.Code);
                if (checkRole == null) newRoleList.Add(role);
            }
            await _roleService.AddRangeAsync(newRoleList);
            return new();
        }
    }
}
