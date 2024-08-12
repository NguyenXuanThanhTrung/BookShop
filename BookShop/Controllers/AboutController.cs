using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapShop.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {
        [Route("about")]
        [Route("")]
        public IActionResult About()
        {
            return View();
        }
    }
}
