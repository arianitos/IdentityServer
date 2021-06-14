using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.Entities.Identity
{
    public class UserIdentityUserToken : IdentityUserToken<string>
    {
        public string Tenant { get; set; }
    }
}





