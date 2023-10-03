using Gestion.Parc.Informatique.Service; // Import necessary services and namespaces

namespace Gestion.Parc.Informatique.Authorization
{
    // JwtMiddleware is a middleware component for JWT authentication
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // Invoke method is called for each HTTP request
        public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtils)
        {
            // Retrieve the JWT token from the Authorization header
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            // Validate the token using JwtUtils and get the user ID
            var userId = jwtUtils.ValidateToken(token);

            if (userId != null)
            {
                // If the token is valid, attach the user to the context
                // This allows the application to access user information in subsequent middleware or controllers
                context.Items["User"] = userService.GetById(userId.Value);
            }

            // Continue processing the request pipeline
            await _next(context);
        }
    }
}
