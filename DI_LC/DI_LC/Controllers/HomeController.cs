using DI_LC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_LC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;

        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;


        public HomeController(ITransientService transientService1, ITransientService transientService2, IScopedService scopedService1, IScopedService scopedService2, ISingletonService singletonService1, ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            ViewBag.message1 = "First Instance " + _transientService1.GetID();
            ViewBag.message2 = "Second Instance " + _transientService2.GetID();

            ViewBag.message3 = "First Instance " + _scopedService1.GetID();
            ViewBag.message4 = "Second Instance " + _scopedService2.GetID();

            ViewBag.message6 = "First Instance " + _singletonService1.GetID();
            ViewBag.message7 = "Second Instance " + _singletonService2.GetID();

            return View();
        }
    }
}
