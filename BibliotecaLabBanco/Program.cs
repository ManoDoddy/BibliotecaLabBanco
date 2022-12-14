using BibliotecaLabBanco.Database;
using BibliotecaLabBanco.Database.Interfaces;
using BibliotecaLabBanco.Repository;
using BibliotecaLabBanco.Repository.Interfaces;
using BibliotecaLabBanco.Services;
using BibliotecaLabBanco.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IPlatformMySql>( _ => new PlatformMySql(builder.Configuration["MySqlConnectionString"]));

builder.Services.AddTransient<ILivroRepository, LivroRepository>();

builder.Services.AddTransient<ILivroService, LivroService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
