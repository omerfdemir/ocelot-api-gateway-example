using DBModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IdentityServerPolicyBasedAuth.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<ApplicationUser> SignUp([FromBody] UserCreateDTO userCreateDto)
    {
        var user = new ApplicationUser()
        {
            Id = Guid.NewGuid().ToString(),
            UserName = userCreateDto.Username,
            PasswordHash = userCreateDto.Password,
        };

        await _accountService.UserManager.CreateAsync(user);
        await _accountService.RoleManager.CreateAsync(new IdentityRole("Test Role"));
        await _accountService.UserManager.AddToRoleAsync(user, "Test Role");

        var appUser = await _accountService.UserManager.FindByIdAsync(user.Id);
        var roles = await _accountService.UserManager.GetRolesAsync(appUser);

        return appUser;

    }
}