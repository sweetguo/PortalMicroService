using System.Threading.Tasks;
using Abp.Application.Services;
using Institute.Portal.Authorization.Accounts.Dto;

namespace Institute.Portal.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
