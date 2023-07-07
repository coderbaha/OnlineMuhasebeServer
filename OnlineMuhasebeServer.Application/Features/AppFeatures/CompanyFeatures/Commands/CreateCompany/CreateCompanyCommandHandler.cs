using MediatR;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;
        public CreateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = await _companyService.GetCompanyByName(request.Name, cancellationToken);
            if (company != null) { throw new System.Exception("Bu şirket adı daha önce kullanılmış"); }
            await _companyService.CreateCompany(request, cancellationToken);
            return new();
        }
    }
}
