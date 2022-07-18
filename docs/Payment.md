# SightSound.TicketingSDK.Model.Payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTime** |  | [optional] 
**Amount** | **decimal** |  | [optional] 
**PaymentType** | **ReceiptPaymentType** |  | 
**AccountNumber** | **string** |  | [optional] 
**TransSequenceNumber** | **long** |  | [optional] 
**Checks** | [**List&lt;PaperCheckRequest&gt;**](PaperCheckRequest.md) |  | [optional] 
**AchRequest** | [**ACHRequest**](ACHRequest.md) |  | [optional] 
**PaymentAch** | [**PaymentAch**](PaymentAch.md) |  | [optional] 
**PaymentCreditCard** | [**PaymentCreditCard**](PaymentCreditCard.md) |  | [optional] 
**AdyenPaymentRequest** | [**PaymentsRequest**](PaymentsRequest.md) |  | [optional] 
**GiftCards** | [**List&lt;PaymentGiftCard&gt;**](PaymentGiftCard.md) |  | [optional] 
**StoreCreditCard** | **bool** |  | [optional] 
**ApplyMoa** | **bool** |  | [optional] 
**PaymentAppliedInfo** | **string** |  | [optional] 
**CashApplied** | [**PaymentAppliedDetail**](PaymentAppliedDetail.md) |  | [optional] 
**MoaApplied** | [**PaymentAppliedDetail**](PaymentAppliedDetail.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

