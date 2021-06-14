using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.Entities.Identity
{
    public class UserIdentityUserRole : IdentityUserRole<string>
    {
        public string Tenant { get; set; }
    }
}





