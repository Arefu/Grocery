# Org.OpenAPITools.Api.UsersApi

All URIs are relative to *https://api-prod.prod.fsniwaikato.kiwi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProdMobileV1UsersLoginRefreshtokenPost**](UsersApi.md#prodmobilev1usersloginrefreshtokenpost) | **POST** /prod/mobile/v1/users/login/refreshtoken | Returns an Access JWT Token for use with the API. |

<a id="prodmobilev1usersloginrefreshtokenpost"></a>
# **ProdMobileV1UsersLoginRefreshtokenPost**
> GetCurrentUserResponse ProdMobileV1UsersLoginRefreshtokenPost ()

Returns an Access JWT Token for use with the API.

Check which API calls require this, some do not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProdMobileV1UsersLoginRefreshtokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-prod.prod.fsniwaikato.kiwi";
            var apiInstance = new UsersApi(config);

            try
            {
                // Returns an Access JWT Token for use with the API.
                GetCurrentUserResponse result = apiInstance.ProdMobileV1UsersLoginRefreshtokenPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ProdMobileV1UsersLoginRefreshtokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProdMobileV1UsersLoginRefreshtokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns an Access JWT Token for use with the API.
    ApiResponse<GetCurrentUserResponse> response = apiInstance.ProdMobileV1UsersLoginRefreshtokenPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ProdMobileV1UsersLoginRefreshtokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetCurrentUserResponse**](GetCurrentUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object, containing the JWT Token, expiration date, and other information. |  * Set-Cookie -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

