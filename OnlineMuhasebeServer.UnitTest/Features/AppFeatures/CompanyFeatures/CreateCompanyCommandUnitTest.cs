﻿using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.CompanyFeatures
{
    public sealed class CreateCompanyCommandUnitTest
    {
        private readonly Mock<ICompanyService> _companyService;
        public CreateCompanyCommandUnitTest()
        {
            _companyService = new();
        }
        [Fact]
        public async Task CompanyShouldBeNull()
        {
            Company company = (await _companyService.Object.GetCompanyByName("Test şirket", default))!;
            company.ShouldBeNull();
        }
        [Fact]
        public async Task CreateCompanyCommandResponseShouldnotBeNull()
        {
            var command = new CreateCompanyCommand(
                Name: "Ba Ltd", ServerName: "localhost", DatabaseName: "BAMuhasebeDb", UserId: "", Password: ""
                );
            var handler = new CreateCompanyCommandHandler(_companyService.Object);
            CreateCompanyCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
