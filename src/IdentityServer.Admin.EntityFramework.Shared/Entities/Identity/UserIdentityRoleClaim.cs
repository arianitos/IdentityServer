using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.Entities.Identity
{
    public class UserIdentityRoleClaim : IdentityRoleClaim<string>
    { 
        public string Tenant { get; set; }
    }
}





