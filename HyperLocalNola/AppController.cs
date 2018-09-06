using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperLocalNola
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }
        
      [HttpGet("music")]
        public IActionResult Music()
        {
         return View();
        }
    }
}
