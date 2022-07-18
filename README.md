# SightSound.TicketingSDK - the C# library for the Partner Ticketing API

Sight & Sound Theatres Partner Ticketing API

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.1-SNAPSHOT
- SDK version: 0.0.1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://sight-sound.com](https://sight-sound.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
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

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using SightSound.TicketingSDK.Api;
using SightSound.TicketingSDK.Client;
using SightSound.TicketingSDK.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SightSound.TicketingSDK.Api;
using SightSound.TicketingSDK.Client;
using SightSound.TicketingSDK.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrderControllerApi.CompleteNewOrder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://dev-helios.sight-sound.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*OrderControllerApi* | [**CompleteNewOrder**](docs/OrderControllerApi.md#completeneworder) | **POST** /order/complete | Complete order
*UtilControllerApi* | [**Status**](docs/UtilControllerApi.md#status) | **GET** /system/util/status | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ACHRequest](docs/ACHRequest.md)
 - [Model.AccountAgeIndicatorEnum](docs/AccountAgeIndicatorEnum.md)
 - [Model.AccountChangeIndicatorEnum](docs/AccountChangeIndicatorEnum.md)
 - [Model.AccountInfo](docs/AccountInfo.md)
 - [Model.AccountTypeEnum](docs/AccountTypeEnum.md)
 - [Model.ActivityType](docs/ActivityType.md)
 - [Model.AdditionalContactRole](docs/AdditionalContactRole.md)
 - [Model.Address](docs/Address.md)
 - [Model.AddressExtended](docs/AddressExtended.md)
 - [Model.AddressVerifyStatus](docs/AddressVerifyStatus.md)
 - [Model.Amount](docs/Amount.md)
 - [Model.AmountRuleEnum](docs/AmountRuleEnum.md)
 - [Model.ApplicationInfo](docs/ApplicationInfo.md)
 - [Model.AuthenticationResponseEnum](docs/AuthenticationResponseEnum.md)
 - [Model.BillingAttemptsRuleEnum](docs/BillingAttemptsRuleEnum.md)
 - [Model.BookingLocation](docs/BookingLocation.md)
 - [Model.BrowserInfo](docs/BrowserInfo.md)
 - [Model.CartRequest](docs/CartRequest.md)
 - [Model.CartResponse](docs/CartResponse.md)
 - [Model.ChallengeIndicatorEnum](docs/ChallengeIndicatorEnum.md)
 - [Model.ChannelEnum](docs/ChannelEnum.md)
 - [Model.CheckoutOrder](docs/CheckoutOrder.md)
 - [Model.CommonField](docs/CommonField.md)
 - [Model.CompCodeType](docs/CompCodeType.md)
 - [Model.Company](docs/Company.md)
 - [Model.CreateWebsiteCustomerRequest](docs/CreateWebsiteCustomerRequest.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerAttribute](docs/CustomerAttribute.md)
 - [Model.CustomerAttributeType](docs/CustomerAttributeType.md)
 - [Model.CustomerContactInfo](docs/CustomerContactInfo.md)
 - [Model.CustomerContactInfoCommunicationTag](docs/CustomerContactInfoCommunicationTag.md)
 - [Model.CustomerDocument](docs/CustomerDocument.md)
 - [Model.CustomerPhone](docs/CustomerPhone.md)
 - [Model.CustomerPhoneRequest](docs/CustomerPhoneRequest.md)
 - [Model.CustomerPricingLevel](docs/CustomerPricingLevel.md)
 - [Model.CustomerType](docs/CustomerType.md)
 - [Model.CustomerTypeResponse](docs/CustomerTypeResponse.md)
 - [Model.CustomerUPSAddress](docs/CustomerUPSAddress.md)
 - [Model.DeliveryAddressIndicatorEnum](docs/DeliveryAddressIndicatorEnum.md)
 - [Model.DeliveryAddressUsageIndicatorEnum](docs/DeliveryAddressUsageIndicatorEnum.md)
 - [Model.DeliveryTimeframeEnum](docs/DeliveryTimeframeEnum.md)
 - [Model.Designation](docs/Designation.md)
 - [Model.DeviceRenderOptions](docs/DeviceRenderOptions.md)
 - [Model.DirectoryResponseEnum](docs/DirectoryResponseEnum.md)
 - [Model.DiscountType](docs/DiscountType.md)
 - [Model.DocumentType](docs/DocumentType.md)
 - [Model.EmployeeBenefitType](docs/EmployeeBenefitType.md)
 - [Model.EntityTypeEnum](docs/EntityTypeEnum.md)
 - [Model.Event](docs/Event.md)
 - [Model.ExternalPlatform](docs/ExternalPlatform.md)
 - [Model.FeeItem](docs/FeeItem.md)
 - [Model.FeeKind](docs/FeeKind.md)
 - [Model.FeeType](docs/FeeType.md)
 - [Model.ForexQuote](docs/ForexQuote.md)
 - [Model.FrequencyEnum](docs/FrequencyEnum.md)
 - [Model.GenderEnum](docs/GenderEnum.md)
 - [Model.GroupInfo](docs/GroupInfo.md)
 - [Model.ImpSSIInvoiceCategory](docs/ImpSSIInvoiceCategory.md)
 - [Model.Installments](docs/Installments.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.InvoiceCompany](docs/InvoiceCompany.md)
 - [Model.InvoiceDetail](docs/InvoiceDetail.md)
 - [Model.InvoiceStatus](docs/InvoiceStatus.md)
 - [Model.InvoiceType](docs/InvoiceType.md)
 - [Model.ItemType](docs/ItemType.md)
 - [Model.LineItem](docs/LineItem.md)
 - [Model.LocationDescription](docs/LocationDescription.md)
 - [Model.Mandate](docs/Mandate.md)
 - [Model.MerchantDevice](docs/MerchantDevice.md)
 - [Model.MerchantRiskIndicator](docs/MerchantRiskIndicator.md)
 - [Model.MiscEvent](docs/MiscEvent.md)
 - [Model.Name](docs/Name.md)
 - [Model.Note](docs/Note.md)
 - [Model.NoteType](docs/NoteType.md)
 - [Model.OIShowSpecialSituation](docs/OIShowSpecialSituation.md)
 - [Model.OldCustomerType](docs/OldCustomerType.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderCompleteRequest](docs/OrderCompleteRequest.md)
 - [Model.OrderCompleteResponse](docs/OrderCompleteResponse.md)
 - [Model.OrderCustomerRequest](docs/OrderCustomerRequest.md)
 - [Model.OrderItem](docs/OrderItem.md)
 - [Model.OrderItemComp](docs/OrderItemComp.md)
 - [Model.OrderItemDetail](docs/OrderItemDetail.md)
 - [Model.OrderItemDetailPriceRequest](docs/OrderItemDetailPriceRequest.md)
 - [Model.OrderItemPriceRequest](docs/OrderItemPriceRequest.md)
 - [Model.OrderItemPriceResponse](docs/OrderItemPriceResponse.md)
 - [Model.OrderItemStatus](docs/OrderItemStatus.md)
 - [Model.OrderItemTax](docs/OrderItemTax.md)
 - [Model.OrderOrigin](docs/OrderOrigin.md)
 - [Model.OrderStatus](docs/OrderStatus.md)
 - [Model.OrderTicketDeliveryRequest](docs/OrderTicketDeliveryRequest.md)
 - [Model.PaperCheckRequest](docs/PaperCheckRequest.md)
 - [Model.PasswordChangeIndicatorEnum](docs/PasswordChangeIndicatorEnum.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentAccountIndicatorEnum](docs/PaymentAccountIndicatorEnum.md)
 - [Model.PaymentAch](docs/PaymentAch.md)
 - [Model.PaymentAppliedDetail](docs/PaymentAppliedDetail.md)
 - [Model.PaymentCreditCard](docs/PaymentCreditCard.md)
 - [Model.PaymentGiftCard](docs/PaymentGiftCard.md)
 - [Model.PaymentGiftCardRequest](docs/PaymentGiftCardRequest.md)
 - [Model.PaymentMethodDetails](docs/PaymentMethodDetails.md)
 - [Model.PaymentRequest](docs/PaymentRequest.md)
 - [Model.PaymentTerms](docs/PaymentTerms.md)
 - [Model.PaymentsRequest](docs/PaymentsRequest.md)
 - [Model.PhoneType](docs/PhoneType.md)
 - [Model.PricingLevel](docs/PricingLevel.md)
 - [Model.Receipt](docs/Receipt.md)
 - [Model.ReceiptDetail](docs/ReceiptDetail.md)
 - [Model.ReceiptDetailType](docs/ReceiptDetailType.md)
 - [Model.ReceiptPaymentType](docs/ReceiptPaymentType.md)
 - [Model.ReceiptReasonCode](docs/ReceiptReasonCode.md)
 - [Model.ReceiptStatus](docs/ReceiptStatus.md)
 - [Model.ReceiptType](docs/ReceiptType.md)
 - [Model.RecurringProcessingModelEnum](docs/RecurringProcessingModelEnum.md)
 - [Model.RiskData](docs/RiskData.md)
 - [Model.SDKEphemPubKey](docs/SDKEphemPubKey.md)
 - [Model.Schedule](docs/Schedule.md)
 - [Model.SdkInterfaceEnum](docs/SdkInterfaceEnum.md)
 - [Model.SdkUiTypeEnum](docs/SdkUiTypeEnum.md)
 - [Model.SeatStatus](docs/SeatStatus.md)
 - [Model.SeatType](docs/SeatType.md)
 - [Model.SeatingProfile](docs/SeatingProfile.md)
 - [Model.SeatingProfileDetail](docs/SeatingProfileDetail.md)
 - [Model.SeatingTemplate](docs/SeatingTemplate.md)
 - [Model.SeatingTemplateSection](docs/SeatingTemplateSection.md)
 - [Model.SeatingTemplateSectionSeat](docs/SeatingTemplateSectionSeat.md)
 - [Model.ShopperInteractionDevice](docs/ShopperInteractionDevice.md)
 - [Model.ShopperInteractionEnum](docs/ShopperInteractionEnum.md)
 - [Model.ShowBudget](docs/ShowBudget.md)
 - [Model.ShowOverflowSeat](docs/ShowOverflowSeat.md)
 - [Model.ShowScheduleSeat](docs/ShowScheduleSeat.md)
 - [Model.ShowTrackingDetail](docs/ShowTrackingDetail.md)
 - [Model.Special](docs/Special.md)
 - [Model.SpecialAssociatedEvent](docs/SpecialAssociatedEvent.md)
 - [Model.SpecialDetail](docs/SpecialDetail.md)
 - [Model.SpecialRestrictionType](docs/SpecialRestrictionType.md)
 - [Model.SpecialSituationDefinition](docs/SpecialSituationDefinition.md)
 - [Model.SpecialSubTypeCode](docs/SpecialSubTypeCode.md)
 - [Model.SpecialType](docs/SpecialType.md)
 - [Model.SpecialTypeCode](docs/SpecialTypeCode.md)
 - [Model.Split](docs/Split.md)
 - [Model.SplitAmount](docs/SplitAmount.md)
 - [Model.SyncSource](docs/SyncSource.md)
 - [Model.TaxCategoryEnum](docs/TaxCategoryEnum.md)
 - [Model.TaxJurisdictionType](docs/TaxJurisdictionType.md)
 - [Model.TaxType](docs/TaxType.md)
 - [Model.TheaterEntrance](docs/TheaterEntrance.md)
 - [Model.TheaterLocation](docs/TheaterLocation.md)
 - [Model.ThreeDS2RequestData](docs/ThreeDS2RequestData.md)
 - [Model.ThreeDSecureData](docs/ThreeDSecureData.md)
 - [Model.TicketBatch](docs/TicketBatch.md)
 - [Model.TicketPrintStatus](docs/TicketPrintStatus.md)
 - [Model.TransactionTypeEnum](docs/TransactionTypeEnum.md)
 - [Model.TypeEnum](docs/TypeEnum.md)
 - [Model.WatchList](docs/WatchList.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="DEV"></a>
### DEV

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: N/A

<a name="PROD"></a>
### PROD

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: N/A
