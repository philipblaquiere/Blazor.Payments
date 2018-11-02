window.blazorPaymentsInterop = {
	canMakePayment: function () {
		return window.PaymentRequest;
	},
	showPayment: async function (paymentMethods, paymentDetails, paymentOptions) {

		var details = {
			shippingOptions: paymentDetails.shippingOptions,
			total: paymentDetails.total,
			displayItems: paymentDetails.displayItems
		};

		var request = new PaymentRequest(
			paymentMethods,
			details,
			paymentOptions
		);

		request.addEventListener('shippingaddresschange', async function (event) {
			var paymentDetailsResponse = await DotNet.invokeMethodAsync('Blazor.Payments', 'OnShippingAddressChangedInterop', event.target.shippingAddress);

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

			event.updateWith(paymentDetails);
		});

		request.addEventListener('shippingoptionchange', async function (event) {
			var paymentDetailsResponse = await DotNet.invokeMethodAsync('Blazor.Payments', 'OnShippingOptionChangedInterop', event.target.shippingOption);

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

			event.updateWith(paymentDetails);
		});

		try {
			var response = await request.show();

			var processPaymentResult = await DotNet.invokeMethodAsync('Blazor.Payments', 'OnPaymentResponseInterop', response);

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
