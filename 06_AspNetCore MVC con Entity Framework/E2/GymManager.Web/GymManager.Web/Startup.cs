using GymManager.AplicationsServices.Members;
using GymManager.AplicationsServices.MembershipTypes;
using GymManager.AplicationsServices.Navigation;
using GymManager.Core.Members;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<GymManagerContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).
                AddEntityFrameworkStores<GymManagerContext>()
                .AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");


            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddTransient<IMembersAppService, MembersAppService>();

            services.AddTransient<IMenuAppService, MenuAppService>();

            services.AddTransient<IMembershipTypeAppService, MembershipTypeAppService>();

            services.AddTransient<IRepository<int, Member>, MembersRepository>();

            services.AddSingleton((ILogger)new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File("wwwroot/Logs/applog.txt")
            .CreateLogger());

            services.AddWkhtmltopdf();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var defaultDateCulture = "es-MX";
            var ci = new CultureInfo(defaultDateCulture);

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo>
                {
                    ci,
                },
                SupportedUICultures = new List<CultureInfo>
                {
                    ci,
                }
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            //app.UseAuthorization();

            //app.UseAuthentication();

            app.UseAuthentication();
            app.UseAuthorization();




            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}