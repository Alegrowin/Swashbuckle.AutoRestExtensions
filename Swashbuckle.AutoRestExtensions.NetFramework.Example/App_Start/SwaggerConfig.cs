using System.Web.Http;
using WebActivatorEx;
using Swashbuckle.AutoRestExtensions.NetFramework.Example;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Swashbuckle.AutoRestExtensions.NetFramework.Example
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(
                    c =>
                    {
                        c.SingleApiVersion("v1", "Web Api");
                        c.ApplyAutoRestFilters(
                            new SwaggerDocsConfigExtensionsConfiguration()
                            {
                                ApplyEnumTypeSchemaFilter = true,
                                ApplyNullableTypeSchemaFilter = true,
                                ApplyNonNullableAsRequiredSchemaFilter = true
                            },
                            null);
                        c.DescribeAllEnumsAsStrings(true);
                    })
                .EnableSwaggerUi();
        }
    }
}
