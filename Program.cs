using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ZencareLTE.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<IdentityAccountDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");



builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityAccountDbContext>();


builder.Services.AddDbContext<IdentityAccountDbContext>(
    options => options.UseSqlServer(connectionString));

//builder.Services.AddAuthentication(options =>
//    {
//        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//        options.DefaultChallengeScheme = OktaDefaults.MvcAuthenticationScheme;
//    })
// .AddCookie()
// .AddOktaMvc(new OktaMvcOptions
// {
//     OktaDomain = builder.Configuration["Okta:OktaDomain"],
//     ClientId = builder.Configuration["Okta:ClientId"],
//     ClientSecret = builder.Configuration["Okta:ClientSecret"]
// });

builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = builder.Configuration["Auth0:Domain"];
    options.ClientId = builder.Configuration["Auth0:ClientId"];
});

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddRazorPages();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseDefaultFiles();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.MapControllers();
app.UseAuthentication(); ;

app.Run();
