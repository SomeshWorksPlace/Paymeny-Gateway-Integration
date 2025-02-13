using Paymeny_Gateway_Integration.Models;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paymeny_Gateway_Integration.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PaymentProcess(PaymentModel model)
        {
            try 
            {
                Stripe.StripeConfiguration.ApiKey = "Secrete_Key";

                var option = new ChargeCreateOptions
                {
                    Amount = (long)(Convert.ToDecimal (model.Amount) * 100),
                    Currency = "USD",
                    Source = "tok_visa",
                    Description = "Test Payment",

                };

                var service = new ChargeService();

                Charge charge = service.Create(option);

                if (charge.Status == "succeeded")
                {
                    ViewBag.Message = "Payment sucessfull";
                    return View("success");
                }
                else
                {
                    ViewBag.Message = "Payment failure";
                    return View("failure");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error:" + ex.Message;
                return View("Failure");
            }   
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Failure()
        {
            return View();
        }
    }
}