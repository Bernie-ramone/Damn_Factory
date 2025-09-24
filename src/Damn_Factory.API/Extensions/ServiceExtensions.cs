namespace Damn_Factory.API.Extensions
{
    public static class ServiceExtensions
    {
        // Add extension methods for IServiceCollection here for cors

        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });

    }
}
