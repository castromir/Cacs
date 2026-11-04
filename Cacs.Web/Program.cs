using Cacs.Application.Services;
using Cacs.Infrastructure;
using Cacs.Infrastructure.SignalR;
using Cacs.Web.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddInfrastructure(
    builder.Configuration,
    builder.Environment);

var app = builder.Build();

app.UseInfrastructure();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapInfrastructureHubs();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

if (app.Environment.IsDevelopment())
{
    await EnsureDevPlayersAsync(app);
}

app.Run();

static async Task EnsureDevPlayersAsync(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var playerService = scope.ServiceProvider.GetRequiredService<PlayerService>();
    var existing = await playerService.ListarAsync();

    if (existing.Count > 0)
    {
        return;
    }

    await playerService.CriarAsync("Nyx");
    await playerService.CriarAsync("Bartô");
}
