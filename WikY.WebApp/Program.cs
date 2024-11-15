using Microsoft.EntityFrameworkCore;
using WikY.Business.Extensions;
using WikY.Repository.Extensions;
using WikY.Repository.Persistence.Contexts;
using WikY.WebApp.Extensions;
using WikY.WebApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();

    builder.Services
        .AddWebApp()
        .AddBusiness()
        .AddRepository(builder.Configuration);
}

var app = builder.Build();
{
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<WikYDbContext>();
        db.Database.Migrate();
    }

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseMiddleware<Redirect404Middleware>();

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Article}/{action=Index}/{id?}");

    app.Run();
}