# Org.OpenAPITools.Api.ShopApi

All URIs are relative to *https://api-prod.prod.fsniwaikato.kiwi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProdMobileEcommProductsPNSStoreGuidSearchqtermPost**](ShopApi.md#prodmobileecommproductspnsstoreguidsearchqtermpost) | **POST** /prod/mobile/ecomm-products/PNS/{store-guid}/search?q&#x3D;{term} | Search for Items in Shop |

<a id="prodmobileecommproductspnsstoreguidsearchqtermpost"></a>
# **ProdMobileEcommProductsPNSStoreGuidSearchqtermPost**
> ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200Response ProdMobileEcommProductsPNSStoreGuidSearchqtermPost (Guid storeGuid, string term)

Search for Items in Shop

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProdMobileEcommProductsPNSStoreGuidSearchqtermPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-prod.prod.fsniwaikato.kiwi";
            var apiInstance = new ShopApi(config);
            var storeGuid = 8cd700ae-d96f-4761-bd7a-805d6b93536d;  // Guid | The Store GUID you're searching on.
            var term = Eggs;  // string | The item you're searching for

            try
            {
                // Search for Items in Shop
                ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200Response result = apiInstance.ProdMobileEcommProductsPNSStoreGuidSearchqtermPost(storeGuid, term);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShopApi.ProdMobileEcommProductsPNSStoreGuidSearchqtermPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProdMobileEcommProductsPNSStoreGuidSearchqtermPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for Items in Shop
    ApiResponse<ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200Response> response = apiInstance.ProdMobileEcommProductsPNSStoreGuidSearchqtermPostWithHttpInfo(storeGuid, term);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShopApi.ProdMobileEcommProductsPNSStoreGuidSearchqtermPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeGuid** | **Guid** | The Store GUID you&#39;re searching on. |  |
| **term** | **string** | The item you&#39;re searching for |  |

### Return type

[**ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200Response**](ProdMobileEcommProductsPNSStoreGuidSearchQTermPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example search response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

