using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Meowgic.Service.Interface
{
    public interface ITokenService
    {
        string GenerateAccessToken(int accountId, string role);

        string GenerateRefreshToken();

        ClaimsPrincipal GetClaimsPrincipalFromExpiredToken(string expiredAccessToken);
    }
}
