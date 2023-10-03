using Gestion.Parc.Informatique.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Gestion.Parc.Informatique.Authorization;

// Define a custom authorization attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        // Check if the action allows anonymous access
        var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
        if (allowAnonymous)
            return; // Skip authorization if [AllowAnonymous] attribute is present

        // Perform authorization
        var user = (User)context.HttpContext.Items["User"];
        if (user == null)
        {
            // If the user is not authenticated, return a 401 Unauthorized response
            context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }
}
