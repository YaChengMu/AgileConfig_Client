var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration((_, bd) => {
    bd.AddAgileConfig(e => {
    });
});

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
