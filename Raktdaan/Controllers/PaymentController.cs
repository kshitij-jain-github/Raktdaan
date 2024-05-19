using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Raktdaan.Models;
using Raktdaan.Utility;
using Stripe.Checkout;
using System.Threading.Tasks;
using Raktdaan.Data;

namespace Raktdaan.Controllers
{
    public class PaymentController : Controller
    {
        private readonly StripeSettings _stripeSettings;
        private readonly ApplicationDbContext _db;

        public PaymentController(IOptions<StripeSettings> stripeSettings, ApplicationDbContext db)
        {
            _stripeSettings = stripeSettings.Value;
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCheckoutSession(string donorId)
        {
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Price ="10", // Replace with your actual price ID
                        Quantity = 1,
                    },
                },
                Mode = "payment",
                SuccessUrl = Url.Action("Success", "Payment", new { donorId = donorId }, protocol: Request.Scheme),
                CancelUrl = Url.Action("PaymentFailed", "Payment", null, protocol: Request.Scheme),
            };

            var service = new SessionService();
            Session session = await service.CreateAsync(options);

            return Json(session.Id);
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
