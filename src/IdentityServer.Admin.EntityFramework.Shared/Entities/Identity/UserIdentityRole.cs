using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.Entities.Identity
{
    public class UserIdentityRole : IdentityRole
    {
        public string Tenant { get; set; }
    }
}





