using GraphQL.Orders.Schema;
using GraphQL.Orders.Services;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<OrderType>();
            services.AddTransient<CustomerType>();
            services.AddTransient<OrderStatusesEnum>();
            services.AddScoped<OrdersQuery>();
            //services.AddScoped<OrdersSchema>();
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDependencyResolver>(
                c => new FuncDependencyResolver(type => c.GetRequiredService(type)));
            var sp = services.BuildServiceProvider();
            services.AddScoped<ISchema>(_ => new OrdersSchema(type => (GraphType)sp.GetService(type)) { Query = sp.GetService<OrdersQuery>() });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

           // app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
