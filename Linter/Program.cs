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
using Npgsql;
using Microsoft.FluentUI.AspNetCore.Components.Components.Tooltip;
using Microsoft.JSInterop;
using FastReport.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddFluentUIComponents();

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();


builder.Services.AddCascadingAuthenticationState();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                 throw new InvalidOperationException("String de conex�o 'DefaultConnection' n�o foi encontrada.");

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

builder.Services.AddAuthorization(options =>
{
    //em teoria isso aq serve pra usar as claims como autoriza��o em alguma tela
    options.AddPolicy("RequerAdmin",
         policy => policy.RequireClaim("Administrator"));
});

builder.Services.AddAuthenticationCore();


//builder.Services.AddIdentity<TAB001_Usuarios, IdentityRole<int>>()
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();


//builder.Services.AddIdentity<TAB001_Usuarios, IdentityRole<int>>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>()  // Configura o contexto de DB
//    .AddRoles<IdentityRole<int>>()  // Registra os pap�is (roles)
//    .AddSignInManager()  // Gerenciador de login
//    .AddDefaultTokenProviders();  // Token de confirma��o, etc.


builder.Services.AddIdentityCore<TAB001_Usuarios>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequerAdmin",
         policy => policy.RequireRole("Administrator"));
});


//garante que as migrations estejam aplicadas ao banco
using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate(); // Aplica migra��es pendentes
}


#region Inje��es de depend�ncia

#region Singletons
builder.Services.AddSingleton<ToastService>();
builder.Services.AddSingleton<IEmailSender<TAB001_Usuarios>, IdentityNoOpEmailSender>();


#endregion

#region Transients
builder.Services.AddTransient<CAX001_MovimentacoesRepositorio>();
builder.Services.AddTransient<CAX002_MovimentacoesCanceladasRepositorio>();
builder.Services.AddTransient<CNT001_ContasGerenciaisRepositorio>();
builder.Services.AddTransient<CNT002_ContasExcluidasRepositorio>();
builder.Services.AddTransient<TAB002_CargosRepositorio>();
#endregion

#region Scopeds
builder.Services.AddScoped<TAB001_UsuariosRepositorio>();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<ITooltipService, TooltipService>();
builder.Services.AddScoped<FastRelatorios>();
builder.Services.AddScoped<SignInManager<TAB001_Usuarios>>();
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
//app.MapRazorPages();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();