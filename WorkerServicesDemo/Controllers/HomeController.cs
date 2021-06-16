using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WorkerServicesDemo.Data.EntityClasses;

namespace WorkerServicesDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var res = await Demo.GetAllDemos();
            return View(res.FirstOrDefault());
        }

        [HttpPost]
        public async Task<IActionResult> Index(DemoEntity model)
        {
            await Demo.New(model);
            return RedirectToAction("Index");
        }
    }
}
