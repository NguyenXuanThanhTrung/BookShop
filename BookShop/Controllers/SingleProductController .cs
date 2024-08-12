using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapShop.Controllers
{
    [Route("SingleProduct")]
    public class SingleProductController : Controller
    {
        [Route("SingleProduct")]
        [Route("")]
        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}
