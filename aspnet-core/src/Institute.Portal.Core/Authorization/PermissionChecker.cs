using Abp.Authorization;
using Institute.Portal.Authorization.Roles;
using Institute.Portal.Authorization.Users;

namespace Institute.Portal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
