# SightSound.TicketingSDK.Api.OrderControllerApi

All URIs are relative to *https://dev-helios.sight-sound.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompleteNewOrder**](OrderControllerApi.md#completeneworder) | **POST** /order/complete | Complete order


<a name="completeneworder"></a>
# **CompleteNewOrder**
> OrderCompleteResponse CompleteNewOrder (OrderCompleteRequest orderCompleteRequest)

Complete order

Completes a new order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SightSound.TicketingSDK.Api;
using SightSound.TicketingSDK.Client;
using SightSound.TicketingSDK.Model;

namespace Example
{
    public class CompleteNewOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-helios.sight-sound.com";
            // Configure OAuth2 access token for authorization: DEV
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: PROD
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderControllerApi(config);
            var orderCompleteRequest = new OrderCompleteRequest(); // OrderCompleteRequest | 

            try
            {
                // Complete order
                OrderCompleteResponse result = apiInstance.CompleteNewOrder(orderCompleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderControllerApi.CompleteNewOrder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderCompleteRequest** | [**OrderCompleteRequest**](OrderCompleteRequest.md)|  | 

### Return type

[**OrderCompleteResponse**](OrderCompleteResponse.md)

### Authorization

[DEV](../README.md#DEV), [PROD](../README.md#PROD)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

