using FastReport.DataVisualization.Charting;
using Linter.Components;
using Linter.Components.Account;
using Linter.Dados.Contexto;
using Linter.Dados.Repositorios;
using Linter.Modelos.Modelos;
using Linter.Utilidades;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;
using FastReport.Data;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddFluentUIComponents();

builder.Services.AddCascadingAuthenticationState();



builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                 throw new InvalidOperationException("String de conexão 'DefaultConnection' não foi encontrada.");

// essa string serve pra usar o sql server
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddServerSideBlazor(option =>
{
    option.DetailedErrors = true; //serve pra exibir erros no console do site
});

builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(connectionString)
                                                              .EnableDetailedErrors());

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddAuthorizationCore();
builder.Services.AddAuthentication();

//builder.Services.AddIdentity<TAB001_Usuarios, IdentityRole>(opt => 
//{ 
//    //depois de terminar eu ativo td dnv
//    opt.Password.RequireDigit = false;
//    opt.Password.RequiredLength = 1;
//    opt.Password.RequireLowercase= false;
//    opt.Password.RequireUppercase = false;
//    opt.Password.RequireNonAlphanumeric= false;
//    opt.SignIn.RequireConfirmedEmail = false;
//    opt.SignIn.RequireConfirmedPhoneNumber = false;
//    opt.SignIn.RequireConfirmedAccount = false;
//});

builder.Services.AddIdentityCore<TAB001_Usuarios>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

builder.Services.AddFastReport();

#region Injeções de dependência

#region Singletons
builder.Services.AddSingleton<ToastService>();
builder.Services.AddSingleton<IEmailSender<TAB001_Usuarios>, IdentityNoOpEmailSender>();
#endregion

#region Transients
builder.Services.AddTransient<CAX001_MovimentacoesRepositorio>();
builder.Services.AddTransient<CAX002_MovimentacoesCanceladasRepositorio>();
builder.Services.AddTransient<CNT001_ContasGerenciaisRepositorio>();
builder.Services.AddTransient<CNT002_ContasExcluidasRepositorio>();
#endregion

#region Scopeds
builder.Services.AddScoped<TAB001_UsuariosRepositorio>();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
#endregion

#endregion

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
//app.UseFastReport();
app.UseAntiforgery();
//app.MapControllers();
//app.MapBlazorHub();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
