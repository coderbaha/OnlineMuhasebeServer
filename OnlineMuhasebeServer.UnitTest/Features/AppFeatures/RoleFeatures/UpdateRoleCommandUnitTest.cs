using Moq;
using OnlineMuhasebeServer.Application.Features.RoleFeatures.Commands.UpdateRole;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.RoleFeatures
{
    public sealed class UpdateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleService;
        public UpdateRoleCommandUnitTest()
        {
            _roleService = new();
        }
        [Fact]
        public async Task AppRoleShouldNotBe()
        {
            _roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
        }
        [Fact]
        public async Task AppRoleCodeShouldBeUniqe()
        {
            AppRole checkRoleCode = await _roleService.Object.GetByCode("UCAF.Create");
            checkRoleCode.ShouldBeNull();
        }
        [Fact]
        public async Task UpdateRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateRoleCommand(
                Id: "07940d36-043f-42fa-a8bf-4f6ad2ae9a6e",
                Code: "UCAF.Create",
                Name: "Hesap planı kayıt ekleme"
                );
            _roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
            var handler = new UpdateRoleCommandHandler(_roleService.Object);
            UpdateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
