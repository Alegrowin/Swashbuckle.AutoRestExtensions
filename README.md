# Swashbuckle.AutoRestExtensions
[![Build status](https://ci.appveyor.com/api/projects/status/ixj5vywx2217tnye/branch/master?svg=true)](https://ci.appveyor.com/project/Alegrowin/swashbuckle-autorestextensions/branch/master)
For C# developers

# Nuget Package
See https://www.nuget.org/packages/Swashbuckle.AutoRestExtensions/
```
Install-Package Swashbuckle.AutoRestExtensions
```
Starting version 5.6.0, version of this package will follow SwachBuckle version

# Requirements
Install Autorest
```
	npm install -g autorest
```

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
1. Compile the code with Visual Studio 2017

# How to pack
1. Run the following command in VS console
```
Nuget Pack .\Swashbuckle.AutoRestExtensions\Swashbuckle.AutoRestExtensions.csproj -IncludeReferencedProjects
```

Feel free to contribute

### Disclaimer
This work is a fork of @gitfool. See : https://github.com/gitfool/Swashbuckle/tree/autorest-extensions
*** 