using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Institute.Portal.MultiTenancy.Dto;

namespace Institute.Portal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
