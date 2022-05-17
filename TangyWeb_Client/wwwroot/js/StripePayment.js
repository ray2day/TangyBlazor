redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51L036pHzpVLSfxKG7zTDsckYS05N7JCXCTCIQK8HCH01bxg0UnJFkrTng6nYYugkAi2blzORR58S6xQ3Ak75vdCE00PWQnTORB");
    stripe.redirectToCheckout({ sessionId: sessionId });
}