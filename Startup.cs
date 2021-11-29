using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCompany.Service;
using MyCompany.Domain.Repositories;
using MyCompany.Domain.Repositories.Abstract;
using MyCompany.Domain.Repositories.EntityFramework;
using MyCompany.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MyCompany
{
    
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            //���������� ������ �� appsettings.json
            Configuration.Bind("Project", new Config());

            //���������� ������ ���������� ���������� � �������� ��������
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IApartmentsRepository, EFApartmentsRepository>();
            services.AddTransient<IBuildersRepository, EFBuildersRepository>();
            services.AddTransient<IContractsRepository, EFContractsRepository>();
            services.AddTransient<ICustomersRepository, EFCustomersRepository>();
            services.AddTransient<IGKRepository, EFGKRepository>();
            services.AddTransient<IRealtorsRepository, EFRealtorRepository>();
            services.AddTransient<DataManager>();

            //���������� �������� � ��
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //����������� Identity �������
            services.AddIdentity<IdentityUser, IdentityRole>(opts  =>
              {
                  opts.User.RequireUniqueEmail = false;
                  opts.Password.RequiredLength = 6;
                  opts.Password.RequireNonAlphanumeric = false;
                  opts.Password.RequireLowercase = false;
                  opts.Password.RequireDigit = false;
              }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //����������� authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.SlidingExpiration = true;
            });

            //����������� �������� ����������� ��� Admin Area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });
            //��������� ��������� ������������ � ������������� (MVC)
            services.AddControllersWithViews(x =>
                {
                    x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
                })
                //���������� ������������� � asp.net core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //����� ������� ����������� middleware
            
            //� �������� ���������� ��� ����� ������ ��������� ���������� �� �������
            if (env.IsDevelopment())   app.UseDeveloperExceptionPage();


            //���������� ��������� ��������� ������ � ���������� (css, js � �.�.)
            app.UseStaticFiles();

            //���������� ������� �������������
            app.UseRouting();


            //���������� �������������� � �����������
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //������������ ������ ��� �������� (���������)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}