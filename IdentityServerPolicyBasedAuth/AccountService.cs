using DBModel;
using Microsoft.AspNetCore.Identity;

namespace IdentityServerPolicyBasedAuth;

public class AccountService: IAccountService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AccountService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;

    }
    
    
    public UserManager<ApplicationUser> UserManager
    {
        get
        {
            return _userManager;
        }
    }
    
    public RoleManager<IdentityRole> RoleManager
    {
        get
        {
            return _roleManager;
        }
    }
}