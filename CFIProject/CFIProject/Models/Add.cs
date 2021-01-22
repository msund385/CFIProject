using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFIProject.Models
{
    
    public class Add : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
