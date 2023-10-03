using System.Net;
using System.Text;
using Gestion.Parc.Informatique.Authorization;
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Helpers;
using Gestion.Parc.Informatique.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var env = builder.Environment;

// Add services to the container.
// use sql server db in production and sqlite db in development
if (env.IsProduction())
    services.AddDbContext<AppDbContext>();
else
    services.AddDbContext<AppDbContext, SqliteDbContext>();

services.AddControllers();


// configure automapper with all automapper profiles from this assembly
builder.Services.AddAutoMapper(typeof(Program));

// configure DI for application services
builder.Services.AddScoped<IJwtUtils, JwtUtils>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEquipementService, EquipementService>();
builder.Services.AddScoped<IAuthManageService, AuthManageService>();

builder.Services.AddSingleton<ISharedDataService, SharedDataService>(); // Store Global Sahred Data 
builder.Services.AddScoped<ISharedFunctionService, SharedFunctionService>(); // Contains Most Commun Functions
builder.Services.AddHostedService<LookupService>();   // Lunch with app Start up 

// Add JWT authentication
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("qwertyuiopasdfghjklzxcvbnm123456"))
        };
    });
services.AddScoped<PermissionRepository>();
services.AddAuthorization(options =>
    {
        var serviceProvider = services.BuildServiceProvider();
        var permissionRepository = serviceProvider.GetRequiredService<PermissionRepository>();

        var permissions = permissionRepository.RetrievePermissionsFromDatabase();

        foreach (var permission in permissions)
        {
            options.AddPolicy(permission.PermissionName, policy =>
            {
                policy.RequireClaim("Permission", permission.PermissionName);
            });
        }
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
List<string> ApiExplorerGroupes = new List<string>() { "Authentications", "All", "Gestion Parc Informatique" };
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
{

    foreach (var item in ApiExplorerGroupes)
    {

        c.SwaggerDoc(item, new OpenApiInfo
        {
            Title = "" + item,
            Version = "1.0.0",
            Description = "" + item
        });
    }
    c.DocInclusionPredicate((docName, apiDesc) =>
        {
            if (docName == "All") return true;
            if (!apiDesc.TryGetMethodInfo(out var methodInfo))
                return false;

            var controllerAttributes = methodInfo.DeclaringType.GetCustomAttributes(true)
                .OfType<ApiExplorerSettingsAttribute>();

            var actionAttributes = methodInfo.GetCustomAttributes(true)
                .OfType<ApiExplorerSettingsAttribute>();

            var combinedAttributes = controllerAttributes.Union(actionAttributes);

            return combinedAttributes.Any(attr => attr.GroupName == docName);
        });
    // c.TagActionsBy(api => new[] { api.GroupName }); 

    // Add more SwaggerDocs for each API you want to separate
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        foreach (var item in ApiExplorerGroupes.OrderBy(k => k))
        {
            c.SwaggerEndpoint("/swagger/" + item + "/swagger.json", item);// + " ApiDOC");
        }
        // Add more SwaggerEndpoints for each API you want to separate
    });
}

app.UseHttpsRedirection();

// global cors policy
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();
// custom jwt auth middleware
app.UseMiddleware<JwtMiddleware>();
app.UseResponseCaching();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
