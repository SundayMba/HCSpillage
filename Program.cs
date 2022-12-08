using HCSpillage.Data;
using HCSpillage.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HCSpillage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //register services to the http pipeline
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IDataPresentation, DataPresentationImplementation>();
            builder.Services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DataPresentation"));
            });
            builder.Services.AddDbContextPool<AppDbContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("SmarterAspDb"));
            });

            builder.Services.AddIdentity<ApplicationDbUser, IdentityRole>()
                            .AddEntityFrameworkStores<AppDbContext>();
            //build the service
            var app = builder.Build();

            //configure middlewares
            if(!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}/{id?}"
                );

            app.Run();
        }
    }
}