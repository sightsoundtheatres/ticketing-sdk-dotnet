# SightSound.TicketingSDK.Api.UtilControllerApi

All URIs are relative to *https://dev-helios.sight-sound.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Status**](UtilControllerApi.md#status) | **GET** /system/util/status | 


<a name="status"></a>
# **Status**
> void Status ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SightSound.TicketingSDK.Api;
using SightSound.TicketingSDK.Client;
using SightSound.TicketingSDK.Model;

namespace Example
{
    public class StatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-helios.sight-sound.com";
            // Configure OAuth2 access token for authorization: DEV
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: PROD
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilControllerApi(config);

            try
            {
                apiInstance.Status();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilControllerApi.Status: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[DEV](../README.md#DEV), [PROD](../README.md#PROD)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

