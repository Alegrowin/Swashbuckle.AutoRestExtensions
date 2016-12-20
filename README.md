# Swashbuckle.AutoRestExtensions
For C# developers
### Disclaimer
I did not code this, @gitfool did @ https://github.com/gitfool/

see : https://github.com/gitfool/Swashbuckle/tree/autorest-extensions
*** 

# Nuget Package
See https://www.nuget.org/packages/Swashbuckle.AutoRestExtensions/
```
Install-Package Swashbuckle.AutoRestExtensions
```

# Requirements
1. Install those packages
  1. Swashbuckle
  2. Swashbuckle.AutorestExtensions
  3. Autorest (you will need any version > 0.17.3 released on 31 oct. 2016. I am using nightly builds, see https://www.myget.org/gallery/autorest)

# How to use
## Swagger.config
```C#
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
```

## Some explanations
### NullableTypeSchemaFilter
This Filter will apply the x-nullable attributes in the generated JSON, x-nullable is handled poorly in V 0.17.3 of Autorest so this is why I recommend using nightly. If you don't want to use nightly build you may end up having your complex property like `SomeDto.List<Guid>` generated as `SomeDto.List<Guid?>`. See https://github.com/Azure/autorest/pull/1578 for more information about Enumerable being generated with nullable properties.

### NonNullableAsRequiredSchemaFilter
This looks at the schema for the x-nullable property and if the property is marked as x-nullable = false, it add the property in the required array which will be validation against null when generated back to C#.

# How to build
1. Compile the code with Visual Studio
2. Run the following command in VS console
```
Nuget Pack .\Swashbuckle.AutoRestExtensions\Swashbuckle.AutoRestExtensions.csproj -IncludeReferencedProjects
```

Feel free to contribute
