using System.Threading.Tasks;
using Abp.Application.Services;
using Institute.Portal.Sessions.Dto;

namespace Institute.Portal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
