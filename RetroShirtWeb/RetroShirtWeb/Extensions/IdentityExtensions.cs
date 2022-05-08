using System.Security.Claims;
using System.Security.Principal;

namespace RetroShirtWeb.Extensions
{
    public static class IdentityExtensions
    {          
            public static string GetName(this IIdentity identity)
            {
                ClaimsIdentity claimsIdentity = identity as ClaimsIdentity;
                Claim claim = claimsIdentity?.FindFirst(ClaimTypes.Role);

                return claim?.Value ?? string.Empty;
            }
        
    }
}
