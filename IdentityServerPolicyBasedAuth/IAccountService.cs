using DBModel;
using Microsoft.AspNetCore.Identity;

namespace IdentityServerPolicyBasedAuth;

public interface IAccountService
{
    UserManager<ApplicationUser> UserManager { get; }
    RoleManager<IdentityRole> RoleManager { get; }
}