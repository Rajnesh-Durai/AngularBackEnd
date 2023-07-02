using BigBangAngular30thJune.Authentication;
using System.Security.Claims;

namespace BigBangAngular30thJune.Repository.Token
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);
        string GetRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
