namespace Gestion.Parc.Informatique.Authorization;

using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Models.Auth;
using Gestion.Parc.Informatique.Service;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

public interface IJwtUtils
{
    public string GenerateToken(User user);
    public int? ValidateToken(string token);
}

public class JwtUtils : IJwtUtils
{
    // private readonly AppSettings _appSettings;
    private readonly IConfiguration _config;
    private readonly IServiceScopeFactory _scopeFactory;

    public JwtUtils(IConfiguration config, IServiceScopeFactory scopeFactory)
    {
        _config = config;
        _scopeFactory = scopeFactory;
    }

    public string GenerateToken(User user)
    {
        // generate token that is valid for 7 days
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = System.Text.Encoding.UTF8.GetBytes(_config.GetSection("Appsettings:Secret").Value);
        // var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        var userWithPer = new UserWithPermissionDto();
        using (var scope = _scopeFactory.CreateScope())
        {
            // Using Context inside IHosted Service
            var _authService = scope.ServiceProvider.GetRequiredService<PermissionRepository>();

            userWithPer = _authService.GetUserWithPermissions(user.Id);
        }

        var claims = new List<Claim>();
        claims.Add(new Claim("id", user.Id.ToString()));
        foreach (var item in userWithPer.PermissionNames)
        {
            claims.Add(new Claim("Permission", item));
        }
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims.ToArray()),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    public int? ValidateToken(string token)
    {
        if (token == null)
            return null;

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = System.Text.Encoding.UTF8.GetBytes(_config.GetSection("Appsettings:Secret").Value);
        // var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

            // If not Validated Return Null

            // return user id from JWT token if validation successful
            return userId;
        }
        catch
        {
            // return null if validation fails
            return null;
        }
    }
}