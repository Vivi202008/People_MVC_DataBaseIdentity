using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using People_MVC.Models.Service;
using People_MVC.Models.Repo;
using People_MVC.Data;
using People_MVC.Models;
using Microsoft.AspNetCore.Identity;

namespace People_MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddDefaultUI()
                .AddEntityFrameworkStores<PeopleDbContext>();

            services.AddControllersWithViews();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleRepo,DbPeople>();

            services.AddScoped<ICityRepo, DbCity>();
            services.AddScoped<ICityService, CityService>();

            services.AddScoped<ICountryRepo, DbCountry>();
            services.AddScoped<ICountryService, CountryService>();

            services.AddScoped<ILanguageRepo, DbLanguage>();
            services.AddScoped<ILanguageService, LanguageService>();

            services.AddScoped<IPersonLanguageRepo, DbPersonLanguage>();

            services.AddDbContext<PeopleDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("PeopleDb")));

            services.AddIdentity<User, IdentityRole>(options => { })
               .AddEntityFrameworkStores<PeopleDbContext>();

            //services.AddSingleton<IPeopleService, PeopleService>();
            //services.AddSingleton<IPeopleRepo, InMemoryPeopleRepo>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
