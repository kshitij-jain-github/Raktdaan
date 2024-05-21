using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Raktdaan.Data;
using Raktdaan.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace Raktdaan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FindDonar()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Donar_details(string id)
        {
          /*  var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var payment = _db.Payments
                .FirstOrDefault(p => p.UserId == userId && p.DonorId == id && p.Status == "succeeded");

            if (payment == null)
            {
                return RedirectToAction("CreateCheckoutSession", "Payment", new { donorId = id });
            }*/

            var donor = _db.ApplicationUsers
                .Where(u => u.Id == id)
                .Select(u => new ApplicationUser
                {
                    Full_Name = u.Full_Name, // Adjust according to how you store the user's full name
                    Blood_group = u.Blood_group,
                    City = u.City,
                    State = u.State,
                    Country = u.Country,
                    PhoneNumber = u.PhoneNumber // Adjust if you store contact differently
                })
                .FirstOrDefault();

            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var userList = _db.ApplicationUsers.ToList();
            return Json(new { data = userList });
        }

        // POST
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
