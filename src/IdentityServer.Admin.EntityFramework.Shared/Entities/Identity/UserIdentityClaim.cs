using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.Entities.Identity
{
    public class UserIdentityUserClaim : IdentityUserClaim<string>
    {
        public string Tenant { get; set; }
    }
}






