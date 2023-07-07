using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole
{
    public sealed record RemoveByIdMainRoleCommand(string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;
}
