namespace Swashbuckle.AutoRestExtensions
{
    public class SwaggerDocsConfigExtensionsConfiguration
    {
        public bool ApplyEnumTypeSchemaFilter { get; set; } = false;

        public bool ApplyTypeFormatSchemaFilter { get; set; } = false;

        public bool ApplyNullableTypeSchemaFilter { get; set; } = false;

        public bool ApplyNonNullableAsRequiredSchemaFilter { get; set; } = false;

        public bool EnumTypeModelAsString { get; set; } = false;
    }
}