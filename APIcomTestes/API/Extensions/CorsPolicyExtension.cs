using FluentValidation;

namespace API.Extensions
{
    public static class CorsPolicyExtension
    {
        public static void ConfigureCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(
                opt =>
                {
                    opt.AddDefaultPolicy(builder => builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin());
                });
        }
    }
}
