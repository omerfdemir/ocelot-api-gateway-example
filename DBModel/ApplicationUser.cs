using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace DBModel;

public class ApplicationUser: IdentityUser
{
    [DefaultValue("Default New Field Value")]
    public string? NewField { get; set; }
}