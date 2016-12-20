using Swashbuckle.Application;

namespace Swashbuckle.AutoRestExtensions
{
    public static class SwaggerDocsConfigExtensions
    {
        public static void ApplyAutoRestFilters(this SwaggerDocsConfig config, SwaggerDocsConfigExtensionsConfiguration extensionsConfiguration, object codeGenerationSettings = null)
        {
            if (codeGenerationSettings != null)
            {
                config.DocumentFilter(() => new CodeGenerationSettingsDocumentFilter(codeGenerationSettings));
            }
            if (extensionsConfiguration.ApplyEnumTypeSchemaFilter)
            {
                config.SchemaFilter(() => new EnumTypeSchemaFilter(extensionsConfiguration.EnumTypeModelAsString));
            }
            if (extensionsConfiguration.ApplyTypeFormatSchemaFilter)
            {
                config.SchemaFilter<TypeFormatSchemaFilter>();
            }
            if (extensionsConfiguration.ApplyNullableTypeSchemaFilter)
            {
                config.SchemaFilter<NullableTypeSchemaFilter>();
                if (extensionsConfiguration.ApplyNonNullableAsRequiredSchemaFilter)
                {
                    config.SchemaFilter<NonNullableAsRequiredSchemaFilter>();
                }
            }
            
            config.ApplyFiltersToAllSchemas();
        }
    }
}