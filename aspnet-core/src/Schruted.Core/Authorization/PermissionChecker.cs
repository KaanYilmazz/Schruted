using Abp.Authorization;
using Schruted.Authorization.Roles;
using Schruted.Authorization.Users;

namespace Schruted.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
