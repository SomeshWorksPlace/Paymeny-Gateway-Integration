using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paymeny_Gateway_Integration.Models
{
    public class PaymentModel
    {
        public string CardNumber { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }

        public string CVV { get; set; }
        public string Amount { get; set; }
    }
}