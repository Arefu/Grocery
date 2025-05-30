# Org.OpenAPITools - the C# library for the Foodstuffs API - Pak &#39;n Save &amp; New World

Foodstuffs API, providing access to Pak'nSave and New World stores without using their website or mobile app.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.1
- SDK version: 1.0.0
- Generator version: 7.9.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api-prod.prod.fsniwaikato.kiwi";
            var apiInstance = new LocaleApi(config);

            try
            {
                // Returns all Localized Errors
                Dictionary<string, ProdMobileV1ErrorGet200ResponseValue> result = apiInstance.ProdMobileV1ErrorGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LocaleApi.ProdMobileV1ErrorGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api-prod.prod.fsniwaikato.kiwi*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*LocaleApi* | [**ProdMobileV1ErrorGet**](docs/LocaleApi.md#prodmobilev1errorget) | **GET** /prod/mobile/v1/error | Returns all Localized Errors
*ShopApi* | [**ProdMobileEcommProductsPNSStoreGuidSearchqtermPost**](docs/ShopApi.md#prodmobileecommproductspnsstoreguidsearchqtermpost) | **POST** /prod/mobile/ecomm-products/PNS/{store-guid}/search?q&#x3D;{term} | Search for Items in Shop
*UsersApi* | [**ProdMobileV1UsersLoginRefreshtokenPost**](docs/UsersApi.md#prodmobilev1usersloginrefreshtokenpost) | **POST** /prod/mobile/v1/users/login/refreshtoken | Returns an Access JWT Token for use with the API.


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.GetCurrentUserResponse](docs/GetCurrentUserResponse.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200Response](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200Response.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFilters](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFilters.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersBrands](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersBrands.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersCategories](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersCategories.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersDeals](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersDeals.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersDietaryLifestyle](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseFiltersDietaryLifestyle.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseProductsInner](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseProductsInner.md)
 - [Model.ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseProductsInnerProductImageUrls](docs/ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200ResponseProductsInnerProductImageUrls.md)
 - [Model.ProdMobileV1ErrorGet200ResponseValue](docs/ProdMobileV1ErrorGet200ResponseValue.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

