using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapShop.Controllers
{
    [Route("shopbook")]
    public class ShopController : Controller
    {
        [Route("shop")]
        [Route("")]
        public IActionResult Shop()
        {
            return View();
        }
    }
}
