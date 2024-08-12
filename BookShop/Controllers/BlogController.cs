using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapShop.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("blog")]
        [Route("")]
        public IActionResult Blog()
        {
            return View();
        }
    }
}
