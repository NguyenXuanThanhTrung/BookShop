using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapShop.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        [Route("contact")]
        [Route("")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
