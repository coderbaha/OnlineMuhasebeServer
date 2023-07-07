using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.RoleFeatures.Commands.CreateStaticRoles
{
    public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>;
}
