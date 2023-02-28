using IdentityServer4.Models;
using IdentityServer4.Validation;

namespace IdentityServerPolicyBasedAuth;

public class ResourceOwnerPasswordValidator: IResourceOwnerPasswordValidator
{
    public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
    {

        
            context.Result = new GrantValidationResult(context.UserName, GrantType.ResourceOwnerPassword);
        

    return Task.CompletedTask;
    }
}