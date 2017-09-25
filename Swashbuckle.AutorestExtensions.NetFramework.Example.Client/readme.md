# NetFramework Example client

## Getting Started 
To build the SDKs for My API, simply install AutoRest via `npm` (`npm install -g autorest`) and then run:
> `autorest readme.md`

To see additional help and options, run:
> `autorest --help`

For other options on installation see [Installing AutoRest](https://aka.ms/autorest/install) on the AutoRest github page.

To Ensure client run properly, install the following Nuget packages:
```
Install-Package Microsoft.Rest.ClientRuntime
Install-Package System.Net.Http
Install-Package Newtonsoft.Json

```

---

## Configuration 
The following are the settings for this using this API with AutoRest.

``` yaml
# specify the version of Autorest to use
version: 1.0.1-20170402 

# Output folder
log-file: bin/Debug

input-file: swagger.json

csharp:
  namespace: Swashbuckle.AutorestExtensions.NetFramework.Example.Client
  output-folder : client
```