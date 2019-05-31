window.blazorPaymentsInterop = {
	canMakePayment: async function () {
		if (window.PaymentRequest) {
			return true;
		} else {
			return false;
		}
	},
	showPayment: async function (paymentMethods, paymentDetails, paymentOptions) {
		let { shippingOptions, total, displayItems } = paymentDetails;

		var request = new PaymentRequest(
			paymentMethods,
			{ shippingOptions, total, displayItems },
			getPaymentOptions(paymentOptions)
		);

		request.addEventListener('shippingaddresschange', async function (event) {
			let paymentDetailsResponse = await DotNet.invokeMethodAsync('Blazor.Payments', 'OnShippingAddressChangedInterop', event.target.shippingAddress);
			
			let paymentDetails = getPaymentDetails(paymentDetailsResponse);

			event.updateWith(paymentDetails);
		});

		request.addEventListener('shippingoptionchange', async function (event) {
			let paymentDetailsResponse = await DotNet.invokeMethodAsync('Blazor.Payments', 'OnShippingOptionChangedInterop', event.target.shippingOption);

			let paymentDetails = getPaymentDetails(paymentDetailsResponse);

			event.updateWith(paymentDetails);
		});

		try {
			let response = await request.show();

			let processPaymentResult = await DotNet.invokeMethodAsync('Blazor.Payments', 'OnPaymentResponseInterop', response);

			response.complete(processPaymentResult.result);
		}
		catch (error) {
			var paymentException = {
				code: error.code,
				message: error.message,
				name: error.name
			};

			DotNet.invokeMethodAsync('Blazor.Payments', 'OnPaymentExceptionInterop', paymentException);
		}
		finally {
			request = null;
		}
	}
};

function getPaymentOptions(paymentOptions) {
	let { requestPayerEmail, requestPayerName, requestPayerPhone, requestShipping } = paymentOptions;

	let options = Object.assign({}, { requestPayerEmail, requestPayerName, requestPayerPhone, requestShipping });

	if (paymentOptions.shippingType !== "") {
		options.shippingType = paymentOptions.shippingType;
	}

	return options;
}

function getPaymentDetails(paymentDetailsResponse) {
	let paymentDetails = {};

    if (paymentDetailsResponse.total !== null) {
        paymentDetails.total = paymentDetailsResponse.total;
    }
    if (paymentDetailsResponse.error !== null) {
        paymentDetailspaymentDetails.error = paymentDetailsResponse.error;
    }
    if (paymentDetailsResponse.shippingAddressErrors !== null) {
        paymentDetails.shippingAddressErrors = paymentDetailsResponse.shippingAddressErrors;
    }
    if (paymentDetailsResponse.displayItems !== null) {
        paymentDetails.displayItems = paymentDetailsResponse.displayItems;
    }
    if (paymentDetailsResponse.shippingOptions !== null) {
        paymentDetails.shippingOptions = paymentDetailsResponse.shippingOptions;
    }
    if (paymentDetailsResponse.modifiers !== null) {
        paymentDetails.modifiers = paymentDetailsResponse.modifiers;
    }
    return paymentDetails;
}
