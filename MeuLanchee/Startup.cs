﻿using MeuLanchee.Context;
using Microsoft.EntityFrameworkCore;

namespace MeuLanchee;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        //Definição do serviço de configuração do meu banco de dados
        services.AddDbContext<AppDbContext>(options => 
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


        services.AddControllersWithViews();
        services.AddAuthorization(); // Adiciona o serviço de autorização
    }
    public void configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");

            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

      app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
               
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }

}

