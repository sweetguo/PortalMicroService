using System.Threading.Tasks;
using Institute.Portal.Configuration.Dto;

namespace Institute.Portal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
