using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapShop.Controllers
{
    [Route("checkout")]
    public class CheckOutController : Controller
    {
        [Route("checkout")]
        [Route("")]
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
