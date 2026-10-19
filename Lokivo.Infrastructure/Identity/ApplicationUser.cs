
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace Lokivo.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool MustChangePassword { get; set; }

    }
}
