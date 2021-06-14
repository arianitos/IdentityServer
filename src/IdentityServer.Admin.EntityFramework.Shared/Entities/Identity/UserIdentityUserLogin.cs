using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.Entities.Identity
{
    public class UserIdentityUserLogin : IdentityUserLogin<string>
    {
        public string Tenant { get; set; }
    }
}





