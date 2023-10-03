using Gestion.Parc.Informatique.Data; // Import necessary namespaces
using Gestion.Parc.Informatique.Models.Auth;
using Gestion.Parc.Informatique.Service;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// Define an interface for JWT utility operations
public interface IJwtUtils
{
    // Method to generate a JWT token from a user object
    public string GenerateToken(User user);

    // Method to validate a JWT token and retrieve the user's ID
    public int? ValidateToken(string token);
}

// Implementation of the IJwtUtils interface for JWT token operations
public class JwtUtils : IJwtUtils
{
    private readonly IConfiguration _config; // Configuration for JWT settings
    private readonly IServiceScopeFactory _scopeFactory; // Dependency for service scope

    public JwtUtils(IConfiguration config, IServiceScopeFactory scopeFactory)
    {
        _config = config;
        _scopeFactory = scopeFactory;
    }

    // Method to generate a JWT token from a user object
    public string GenerateToken(User user)
    {
        // Initialize token generation components
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_config.GetSection("Appsettings:Secret").Value);
        var userWithPer = new UserWithPermissionDto();

        // Create a scoped context for accessing services
        using (var scope = _scopeFactory.CreateScope())
        {
            // Resolve the PermissionRepository service
            var _authService = scope.ServiceProvider.GetRequiredService<PermissionRepository>();

            // Retrieve user permissions
            userWithPer = _authService.GetUserWithPermissions(user.Id);
        }

        // Define claims for the JWT token
        var claims = new List<Claim>();
        claims.Add(new Claim("id", user.Id.ToString()));
        foreach (var item in userWithPer.PermissionNames)
        {
            claims.Add(new Claim("Permission", item));
        }

        // Define token descriptor with expiration and signing credentials
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims.ToArray()),
            Expires = DateTime.UtcNow.AddDays(365),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        // Create and write the JWT token
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    // Method to validate a JWT token and retrieve the user's ID
    public int? ValidateToken(string token)
    {
        if (token == null)
            return null;

        // Initialize token validation components
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_config.GetSection("Appsettings:Secret").Value);

        try
        {
            // Validate the token and retrieve its claims
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero // Set clockskew to zero for precise expiration checking
            }, out SecurityToken validatedToken);

            // Extract the user ID from the validated token's claims
            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

            // Return the user ID if validation is successful
            return userId;
        }
        catch
        {
            // Return null if token validation fails
            return null;
        }
    }
}
