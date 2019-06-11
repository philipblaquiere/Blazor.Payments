# Blazor.Payments

[![Build Status](https://travis-ci.org/philipblaquiere/Blazor.Payments.svg?branch=master)](https://travis-ci.org/philipblaquiere/Blazor.Payments) [![NuGet](https://img.shields.io/nuget/v/PhilipBlaquiere.Blazor.Payments.svg)](https://www.nuget.org/packages/PhilipBlaquiere.Blazor.Payments/1.0.1)

Blazor.Payments library brings the W3C API Web Payment standard to Blazor-enabled Web Apps. This library attempts to replicate the Payment Request API documented and updated on [w3c.github.io/payment-request](https://w3c.github.io/payment-request/.).

## Getting Started

Blazor.Payments attempts to replicate the contracts defined by the w3c. You can follow the status of the [Payment Request API](https://w3c.github.io/payment-request/.) and refer to its contents to navigate your way through Blazor.Payments.

First add a reference to the nuget package through:
Package Manager

```sh
PM> Install-Package PhilipBlaquiere.Blazor.Payments -Version 1.0.1
```

dotnet CLI:

```sh
> dotnet add package PhilipBlaquiere.Blazor.Payments --version 1.0.1
```

## Develop

Three objects are needed to instantiate a Payment Request:

- `PaymentMethods[]` [doc](https://w3c.github.io/payment-request/#the-methoddata-argument)
- `PaymentDetailsInit`[doc](https://w3c.github.io/payment-request/#the-details-argument)
- `PaymentOptions`(optional) [doc](https://w3c.github.io/payment-request/#paymentoptions-dictionary)

A Web Payment Request instance can then be created by using the provided builder `PaymentRequestBuilder`:

```csharp
var paymentRequest = PaymentRequestBuilder
    .CreatePaymentRequest(paymentMethods, paymentDetails, paymentOptions)
    .Build();
```

Alternatively, you may choose to build `PaymentMethods[]` using the built in builder (`PaymentOptions` is optional but can be built in the same way):

```csharp
var paymentRequest = PaymentRequestBuilder
    .CreateDefaultPaymentRequest(paymentDetails)
    .AddPaymentMethod(pmb => pmb
        .CreateBasicCardPaymentMethod()
        .AddSupportedNetwork(SupportedNetworkType.Visa)
        .AddSupportedNetwork(SupportedNetworkType.Discover)
        .AddSupportedNetwork(SupportedNetworkType.Mastercard)
        .AddSupportedType(SupportedTypesType.Credit)
        .AddSupportedType(SupportedTypesType.Debit)
        .Build()
    )
    .AddPaymentMethod(pmb => pmb
        .CreateUrlPaymentMethod(SupportedMethodsType.GooglePay)
        .Build()
    )
    .AddPaymentOptions(pob => pob
        .RequestPayerEmail()
        .RequestShipping()
        .ShippingOption(PaymentShippingType.Shipping)
        .Build()
    )
    .Build();
```

Then, await the request's `Show()` function to call the browser's Web Payment Request implementation.

```csharp
await paymentRequest.Show();
```

To verify if the browser supports the Payment Request:

```csharp
bool canMakePayment = await WebPaymentHelper.CanMakePayment();
```

### Configuration

A user may trigger events while interacting with the Browser's Payment Request UI. Blazor.Payments allows the delegation of execution by defining handlers. These handlers are registered as build step `.Configure`.

```csharp
var paymentRequest = PaymentRequestBuilder
    .CreatePaymentRequest(paymentMethods, paymentDetails, paymentOptions)
    .Configure(configurationDelegate =>
    {
        configurationDelegate.ShippingAddressChangedAsync = OnShippingAddressChanged;
        configurationDelegate.ShippingOptionChangedAsync = OnShippingOptionChanged;
        configurationDelegate.PaymentResponseAsync = OnPaymentResponse;
        configurationDelegate.PaymentExceptionAsync = OnPaymentException;
    })
    .Build();
```

- `ShippingAddressChangedAsync` executes whenever a user changes shipping address.
- `ShippingOptionChangedAsync` executes whenever a users changes their payment option (credit cards, etc.)
- `PaymentResponseAsync` executes when a user has entered all their information and presses 'Pay'
- `PaymentExceptionAsync` executes when an exception has happened during the payment request process (including when the user 'cancels' the payment request window).

## Known Issues

The following aren't working on Blazor.Payments (yet):

- `OnPaymentMethodChange` [doc](https://w3c.github.io/payment-request/#onpaymentmethodchange-attribute) \*_Currently not supported by all major Browsers_
- `PaymentDetailsInit`'s `PaymentDetailsModifier[]` is not yet supported
- `PaymentItems`'s `IsPending` property isn't working properly on Edge (Web Payment Request fails to show)
- `paymentRequest.Abort()` haven't implemented yet.

## Roadmap

The Web Payment Request API is still in its very early stages. Both its contract (defined by the w3c) as well as its implementation in major browsers are in early stages. Bare in mind this library is for experimental purposes only. Share your thoughts, comments, and most importantly your suggestions.
