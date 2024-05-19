using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Raktdaan.Models;
using Raktdaan.Utility;
using Stripe.Checkout;
using System.Threading.Tasks;
using System.Security.Claims;
using Raktdaan.Data;

namespace Raktdaan.Controllers
{
    public class PaymentController : Controller
    {
        private readonly StripeSettings _stripeSettings;
         public PaymentController(IOptions<StripeSettings> stripeSettings)
        {
            _stripeSettings = stripeSettings.Value;
         }
             

          public IActionResult Success(string donorId)
        {
            // Store payment information in the database if needed
            return RedirectToAction("Donar_details", "Home", new { id = donorId });
        }
 
        public IActionResult PaymentFailed()
        {
            return View("Failure");
        }
    }
}
