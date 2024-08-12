using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapShop.Controllers
{
    [Route("SinglePost")]
    public class SinglePostController : Controller
    {
        [Route("SinglePost")]
        [Route("")]
        public IActionResult SinglePost()
        {
            return View();
        }
    }
}
