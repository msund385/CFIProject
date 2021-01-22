using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFIProject.Models;

namespace CFIProject.Controllers
{
    public class OhioController : Controller
    {

        private readonly IOhioRepo repo;

        public OhioController(IOhioRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var ohio = repo.GetAllOhio();

            return View(ohio);
        }
        public IActionResult UpdateAllOhio(OhioModels ohio)
        {
            repo.UpdateAllOhio(ohio);

            return RedirectToAction("ViewOhio", new { ohio_ID = ohio.ohio_ID });
        }

        public IActionResult ViewOhio(int id)
        {
            var ohio = repo.GetAllOhio(id);

            return View(ohio);
        }
        public IActionResult UpdateProductToDatabase(OhioModels ohio)
        {
            repo.UpdateAllOhio( ohio);

            return RedirectToAction("ViewOhio", new { id = ohio.ohio_ID });
        }
        public IActionResult UpdateProductModel(int id)
        {
            OhioModels ohio = repo.GetAllOhio(id);
            repo.UpdateAllOhio(ohio);

            if (ohio == null)
            {
                return View("OhioNotFound");
            }
            return View(ohio);


        }
        


















    }

}
