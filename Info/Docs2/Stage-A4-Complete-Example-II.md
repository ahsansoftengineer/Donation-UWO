### IMenu Repo
```csharp
namespace Donation.Application.Common.Persistence
{
  public interface IMenuRepository
  {
    void Add(Menu menu);
  }
}
```
### DB Context
```csharp
namespace Donation.Infrastructure.Persistence
{
  public class DonationDbContext : DbContext
  {
    public DonationDbContext(DbContextOptions<DonationDbContext> options) : base(options) { }
    
    public DbSet<Menu> Menus { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(
        typeof(DonationDbContext).Assembly
      );
      base.OnModelCreating(modelBuilder);
    }
  }
}
```
### Menu Repo
```csharp
namespace Donation.Infrastructure.Persistence.Repositories
{
  public class MenuRepository : IMenuRepository
  {
    private readonly DonationDbContext dbContext;

    public MenuRepository(DonationDbContext dbContext)
    {
      this.dbContext = dbContext;
    }
    public void Add(Menu menu)
    {
      //dbContext.Menus.Add(menu);
      dbContext.Add(menu);
      dbContext.SaveChanges();
    }
  }
}
```
### Dependency Injection
```csharp
namespace Donation.Infrastructure
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection Services, ConfigurationManager Configuration)
    {
      Services
        .AddAuth(Configuration)
        .AddPersistence();
      Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

      return Services;
    }
    public static IServiceCollection AddPersistence(this IServiceCollection Services)
    {
      Services.AddDbContext<DonationDbContext>(options =>
      {
        // TrustServerCertificate=true | Encrypt=false
        options.UseSqlServer("SERVER=localhost;DATABASE=Donation;USER=sa;PASSWORD=asdf1234;Encrypt=false");
      });
      Services.AddScoped<IUserRepository, UserRepository>();
      Services.AddScoped<IMenuRepository, MenuRepository>();

      return Services;
    }
    public static IServiceCollection AddAuth(this IServiceCollection Services, ConfigurationManager Configuration)
    {
      var jwtSettings = new JwtSettings();
      Configuration.Bind(JwtSettings.SectionName, jwtSettings);

      Services.AddSingleton(Options.Create(jwtSettings));
      
      Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
      Services
        .AddAuthentication(options =>
        {
          options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
          options.TokenValidationParameters = new TokenValidationParameters()
          {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret)),

            ValidateIssuer = false,
            ValidateAudience = false,
            ValidAudience = "https://localhost:7228",
            ValidIssuer = "https://localhost:7228",

          };
        });
      return Services;
    }
  }
}
```
### Table Mapping
```csharp
namespace Donation.Infrastructure.Persistence.Configurations
{
  public class MenuConfigurations : IEntityTypeConfiguration<Menu>
  {
    // This File Generated Based on the Image StageA2-EF-Core-Z-DB-Diagram-III.png
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
      ConfigureMenuTable(builder);
      ConfigureMenuSectionTable(builder);
      ConfigureMenuDinnerIdsTable(builder);
      ConfigureMenuReviewIdsTable(builder);
    }

    private void ConfigureMenuReviewIdsTable(EntityTypeBuilder<Menu> builder)
    {
      builder.OwnsMany(m => m.MenuReviewIds, dib =>
      {
        dib.ToTable("MenuReviewIds");
        dib.WithOwner().HasForeignKey("MenuId");
        dib.HasKey("Id");
        dib.Property(d => d.Value)
          .HasColumnName("MenuReviewIds")
          .ValueGeneratedNever();
      }) ;
      builder.Metadata.FindNavigation(nameof(Menu.MenuReviewIds))!
        .SetPropertyAccessMode(PropertyAccessMode.Field);
    }
    private void ConfigureMenuDinnerIdsTable(EntityTypeBuilder<Menu> builder)
    {
      builder.OwnsMany(m => m.DinnerIds, dib =>
      {
        dib.ToTable("MenuDinnerIds");
        dib.WithOwner().HasForeignKey("MenuId");
        dib.HasKey("Id");
        dib.Property(d => d.Value)
          .HasColumnName("DinnerIds")
          .ValueGeneratedNever();
      });
      builder.Metadata.FindNavigation(nameof(Menu.DinnerIds))!
        .SetPropertyAccessMode(PropertyAccessMode.Field);
    }
    private void ConfigureMenuSectionTable(EntityTypeBuilder<Menu> builder)
    {
      // m => Menu
      // sb => Navigation Builder Menu
      // ib => Item Builder
      builder.OwnsMany(
        m => m.Sections, 
        sb =>
        {
          sb.ToTable("MenuSections");
          sb.WithOwner().HasForeignKey("MenuId");
          sb.HasKey("Id", "MenuId");
          sb.Property(s => s.Id)
            .HasColumnName("MenuSectionId")
            .ValueGeneratedNever()
            .HasConversion(
              id => id.Value,
              value => MenuSectionId.Create(value));

          sb.Property(s => s.Name)
            .HasMaxLength(100);

          sb.Property(s => s.Description)
            .HasMaxLength(100);

          sb.OwnsMany(s => s.Items, ib =>
          {
            ib.ToTable("MenuItems");

            ib.WithOwner()
              .HasForeignKey("MenuSectionId", "MenuId");

            ib.HasKey(nameof(MenuItem.Id), "MenuSectionId", "MenuId");

            ib.Property(i => i.Id)
              .HasColumnName("MenuItemId")
              .ValueGeneratedNever()
              .HasConversion(
                id => id.Value,
                value => MenuItemId.Create(value));

            ib.Property(s => s.Name)
              .HasMaxLength(100);

            ib.Property(s => s.Description)
              .HasMaxLength(100);
          });
          sb.Navigation(s => s.Items).Metadata.SetField("_items");
          sb.Navigation(s => s.Items).UsePropertyAccessMode(PropertyAccessMode.Field);

        });
      // ! for tell compiler that their will be no null
      builder.Metadata.FindNavigation(nameof(Menu.Sections))!
        .SetPropertyAccessMode(PropertyAccessMode.Field);
    }
    private void ConfigureMenuTable(EntityTypeBuilder<Menu> builder)
    {
      builder.ToTable("Menus");
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Id)
        .ValueGeneratedNever()
        .HasConversion(
          id => id.Value,
          value => MenuId.Create(value)
      );

      builder.Property(x => x.Name)
        .HasMaxLength(100);

      builder.Property(m => m.Description)
        .HasMaxLength(100);

      builder.OwnsOne(m => m.AverageRating);
      builder.Property(m => m.HostId)
        .HasConversion(
          id => id.Value,
          value => HostId.Create(value)
        );
    }
  }
}
```
