create project with commandline :
dotnet new webapi -n <project-name> -o <project-folder>

create Repositories and IRepositories
Register Service in program.cs with commandLine
builder.Services.AddScoped<IRepository,Repository>()

configure database provider by adding Conection String to appSetting file
"ConnectionStrings": {
"SqlServerConnection": "Server=localhost; Database=myDatabase;TrustServerCertificate=True; Trusted_Connection=True;"
}

create AppStoreService then Register it in program.cs
builder.Service.AddSingleton<AppStoreService>()

create LookupsLoaderService and inherite it from IHostedService to enable load it with startup then Register it in program.cs
builder.Services.AddHostedService<LookupsLoaderService>()

create ProjectContext then Register it and configure database Provider
builder.Services.AddDbContext<project-context>(opt => opt.UseSqlServer(
builder.Configuration.GetConnectionString("SqlServerConnection")
));
