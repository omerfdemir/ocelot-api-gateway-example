using IdentityServer4.Models;

namespace IdentityServerPolicyBasedAuth;

public class IdentityConfig
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new List<IdentityResource> {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };
    
    public static IEnumerable<Client> Clients =>
        new List<Client> {
            new()
            {
                ClientId = "frontend",
                ClientName = "Vue Frontend",
                AllowOfflineAccess = true,
                RequirePkce = true,
                AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                ClientSecrets = { new("Frontend".Sha256())},
                AllowedScopes = {"openid","profile","roles","myApi.read", "myApi.write"},
                RequireConsent = false,
            }
 
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("myApi.read"),
            new ApiScope("myApi.write"),
        };
    
    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource("myApi")
            {
                Scopes = new List<string>{ "myApi.read","myApi.write" },
                ApiSecrets = new List<Secret>{ new Secret("supersecret".Sha256()) }
            }
        };
}