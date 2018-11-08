using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Institute.Portal.MultiTenancy;

namespace Institute.Portal.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
