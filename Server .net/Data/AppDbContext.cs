
using Gestion.Parc.Informatique.Models.Auth;
using Microsoft.EntityFrameworkCore;
namespace Gestion.Parc.Informatique.Data;

public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;
    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"));
    }

    public DbSet<Personne> Personnes { get; set; }

    // --------------------- Gestion des Utilisateur ---------------------
    public DbSet<User> _Users { get; set; }
    public DbSet<UserRole> _UserRoles { get; set; }
    public DbSet<Role> _Roles { get; set; }
    public DbSet<RolePermission> _RolePermissions { get; set; }
    public DbSet<Permission> _Permissions { get; set; }
    public DbSet<UserLogin> _UserLogins { get; set; }

    // --------------------- Gestion Parc Informatique -------------------
    public DbSet<Settings> Settings { get; set; }
    public DbSet<Equipement> Equipements { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Marque> Marques { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Structure> Structures { get; set; }
    public DbSet<Unit> Units { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ChangeTracker.SetAuditProperties();
        return await base.SaveChangesAsync(cancellationToken);
    }
    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        ChangeTracker.SetAuditProperties();
        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
    public override int SaveChanges()
    {
        ChangeTracker.SetAuditProperties();
        return base.SaveChanges();
    }
    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        ChangeTracker.SetAuditProperties();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonneSeed());
        modelBuilder.ApplyConfiguration(new UserSeed());

        modelBuilder.Entity<UserRole>()
                   .HasKey(ur => new { ur.UserId, ur.RoleId });

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.User)
            .WithMany(u => u.Roles)
            .HasForeignKey(ur => ur.UserId);

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(ur => ur.RoleId);

        modelBuilder.Entity<RolePermission>()
        .HasKey(rp => rp.Id);

        modelBuilder.Entity<RolePermission>()
            .HasOne(rp => rp.Role)
            .WithMany(r => r.Permissions)
            .HasForeignKey(rp => rp.RoleId);

        modelBuilder.Entity<RolePermission>()
            .HasOne(rp => rp.Permission)
            .WithMany(p => p.Roles)
            .HasForeignKey(rp => rp.PermissionId);
    }
}
