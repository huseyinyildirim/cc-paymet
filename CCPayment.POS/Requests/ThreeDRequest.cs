namespace CCPayment.POS.Requests
{
    public class ThreeDRequest
    {
        public string HolderName { get; set; }

        public string CardNo { get; set; }

        public string ExpiryMonth { get; set; }

        public string ExpiryYear { get; set; }

        public string CVV { get; set; }

        public decimal Amount { get; set; }
    }
}
