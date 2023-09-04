
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace Common.DecodeJWT
{
    public class DecodeToken
    {
        public static userInfoHelper UserDetail(HttpRequest request)
        {
            string authorizationHeaderValue = request.Headers[HeaderNames.Authorization];
            if (AuthenticationHeaderValue.TryParse(authorizationHeaderValue, out var headerValue))
            {
                var parameter = headerValue.Parameter;
                if (parameter != null && !string.IsNullOrEmpty(parameter))
                {
                    return GetUserInfoFromToken(parameter);
                }
            }
            return null;
        }
        private static userInfoHelper GetUserInfoFromToken(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var decodedToken = tokenHandler.ReadJwtToken(token);
            var r_userId = decodedToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid);
            var r_TenantId = decodedToken.Claims.FirstOrDefault(c => c.Type == "TenantID");
            var r_UserName = decodedToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            int userId = 0;
            int TenantId = 0;
            if (r_userId != null && int.TryParse(r_userId.Value, out userId) && r_TenantId != null && int.TryParse(r_TenantId.Value, out TenantId))
            {
                return new userInfoHelper
                {
                    UserId = userId,
                    TenantId = TenantId,
                };
            }
            return null;
        }
    }
}
