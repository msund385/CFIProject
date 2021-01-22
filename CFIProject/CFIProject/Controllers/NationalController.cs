using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFIProject.Models;
namespace CFIProject.Controllers
{
    public class NationalController : Controller
    {
        private readonly INationalRepo repo;

        public NationalController(INationalRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var national = repo.GetAllNational();

            return View(national);
        }

        public IActionResult UpdateNational(int id)
        {
            var national = repo.GetNational(id);

            repo.UpdateNational(national);

            if (national == null)
            {
                return View("NationalNotFound");
            }
            return View(national);
        }
       


    }
}
