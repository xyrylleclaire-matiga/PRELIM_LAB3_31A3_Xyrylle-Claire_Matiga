using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_31A3_Xyrylle_Claire_Matiga.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_31A3_Xyrylle_Claire_Matiga.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(){
            var customerList = new List<Customer>();

            var regular = new Customer{
                FirstName = "Xyrylle Claire",
                LastName = "Matiga",
                MiddleName = "Lasin",
                bday = new DateTime(2004, 08, 30),
                CustomerId = 1003};

            var regular2 = new Customer{
                FirstName = "Abigail",
                LastName = "Robica",
                MiddleName = "Norte",
                bday = new DateTime(2003, 03, 07),
                CustomerId = 1005
            };

            var regular3 = new Customer
            {
                FirstName = "Milliscent",
                LastName = "Beundia",
                MiddleName = "Northern",
                bday = new DateTime(2001, 05, 30),
                CustomerId = 1001
            };

            var vip = new VipCustomer{
                FirstName = "Shoyou",
                LastName = "Bagarino",
                MiddleName = "Luzong",
                bday = new DateTime(2002, 02, 11),
                CustomerId = 1006,
                IsVip = true};

            var vip2 = new VipCustomer{
                FirstName = "Bruno",
                LastName = "Marsie",
                MiddleName = "Lazy",
                bday = new DateTime(2003, 09, 21),
                CustomerId = 1004,
                IsVip = true
            };

            var vip3 = new VipCustomer
            {
                FirstName = "Rouie Maxine",
                LastName = "Alleje",
                MiddleName = "Buenavintura",
                bday = new DateTime(2004, 12, 12),
                CustomerId = 1002,
                IsVip = true
            };

            var vip4 = new VipCustomer
            {
                FirstName = "Aleia Xyra",
                LastName = "Montealmo",
                MiddleName = "Suasna",
                bday = new DateTime(2000, 11, 12),
                CustomerId = 1004,
                IsVip = true
            };


            customerList.Add(regular3);
            customerList.Add(vip3);
            customerList.Add(regular);
            customerList.Add(vip2);
            customerList.Add(regular2);
            customerList.Add(vip);

            ViewBag.CustomerList = customerList;

            return View(); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
