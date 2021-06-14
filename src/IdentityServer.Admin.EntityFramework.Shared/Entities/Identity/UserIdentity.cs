﻿using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Admin.EntityFramework.Shared.Entities.Identity
{
	public class UserIdentity : IdentityUser
	{
		public string Tenant { get; set; }
	}
}





