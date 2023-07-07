using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.AppEntities;
using System.Collections.Generic;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
    public sealed record CreateStaticMainRolesCommand(
        List<MainRole> roles
        ) : ICommand<CreateStaticMainRolesCommandResponse>;
}
