using CoreWCF;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CoreWcf.Samples.Http
{
    public class NetHttpBindingStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Enable CoreWCF Services, with metadata (WSDL) support
            services.AddServiceModelServices()
                .AddServiceModelMetadata();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseServiceModel(builder =>
            {
                // Add the Calculator Service
                builder.AddService<CalculatorService>(serviceOptions => { })
                // Add NetHttpBinding endpoint
                .AddServiceEndpoint<CalculatorService, ICalculatorService>(new NetHttpBinding(), "/CalculatorService/netHttp");

                // Configure WSDL to be available
                var serviceMetadataBehavior = app.ApplicationServices.GetRequiredService<CoreWCF.Description.ServiceMetadataBehavior>();
                serviceMetadataBehavior.HttpGetEnabled = true;
            });
        }
    }
}