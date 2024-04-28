using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace WebApp.Gestao.Api.Config
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {
            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new OpenApiInfo { Title = "Gestão", Version = "v1" });

                cfg.DocInclusionPredicate((_, api) => !string.IsNullOrEmpty(api.GroupName));

                cfg.CustomSchemaIds(p => p.FullName);

                cfg.TagActionsBy(p =>
                {
                    var prop = p.ActionDescriptor.Properties.FirstOrDefault(p => p.Value is ApiDescriptionActionData);

                    if (prop.Value != null)
                    {
                        var apiDescription = prop.Value as ApiDescriptionActionData;
                        return new[] { apiDescription.GroupName };
                    }

                    return new[] { "undefined" };
                });
            });

            return services;
        }
    }
}
