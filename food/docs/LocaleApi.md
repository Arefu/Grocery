# Org.OpenAPITools.Api.LocaleApi

All URIs are relative to *https://api-prod.prod.fsniwaikato.kiwi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProdMobileV1ErrorGet**](LocaleApi.md#prodmobilev1errorget) | **GET** /prod/mobile/v1/error | Returns all Localized Errors |

<a id="prodmobilev1errorget"></a>
# **ProdMobileV1ErrorGet**
> Dictionary&lt;string, ProdMobileV1ErrorGet200ResponseValue&gt; ProdMobileV1ErrorGet ()

Returns all Localized Errors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProdMobileV1ErrorGetExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocaleApi.ProdMobileV1ErrorGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProdMobileV1ErrorGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all Localized Errors
    ApiResponse<Dictionary<string, ProdMobileV1ErrorGet200ResponseValue>> response = apiInstance.ProdMobileV1ErrorGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocaleApi.ProdMobileV1ErrorGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Dictionary&lt;string, ProdMobileV1ErrorGet200ResponseValue&gt;**](ProdMobileV1ErrorGet200ResponseValue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

