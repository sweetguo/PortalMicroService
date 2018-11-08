using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Institute.Portal.Roles.Dto;
using Institute.Portal.Users.Dto;

namespace Institute.Portal.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
