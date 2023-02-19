using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using MVCBlogProject.Areas.Identity.Data;
using MVCBlogProject.Repositories.Abstract;
using MVCBlogProject.Repositories.Concrete;
using MVCIdentity.Servis;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//�zel sa�lay�c�y� hizmet kapsay�c�s�na ekleme
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>

{
    options.SignIn.RequireConfirmedAccount = true;
    options.Tokens.ProviderMap.Add("CustomEmailConfirmation",
        new TokenProviderDescriptor(
            typeof(CustomEmailConfirmationTokenProvider<ApplicationUser>)));
    options.Tokens.EmailConfirmationTokenProvider = "CustomEmailConfirmation";
}).AddEntityFrameworkStores<ApplicationDbContext>()

   .AddRoles<IdentityRole>()
  .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddTransient<CustomEmailConfirmationTokenProvider<ApplicationUser>>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.User.RequireUniqueEmail = true;
});
builder.Services.AddTransient<IArticleCreateRepository, ArticleCreateRepository>();
//builder.Services.AddTransient<IWriterRepository, WriterRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("IsWriter", policy => policy.RequireClaim("IsWriter", "true"));
});

//Uygulamay� e-postay� destekleyecek �ekilde yap�land�rma
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);
//Varsay�lan etkinlik d��� zaman a��m�
builder.Services.ConfigureApplicationCookie(o => {
    o.ExpireTimeSpan = TimeSpan.FromDays(5);
    o.SlidingExpiration = true;
});

//A�a��daki kod t�m veri koruma belirte�leri zaman a��m� s�resini 3 saat olarak de�i�tirir:
builder.Services.Configure<DataProtectionTokenProviderOptions>(o =>
       o.TokenLifespan = TimeSpan.FromHours(3));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
