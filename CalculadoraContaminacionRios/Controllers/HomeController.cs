using Microsoft.AspNetCore.Mvc;
using CalculadoraContaminacionRios.Models;
using CalculadoraContaminacionRios.Services;

namespace CalculadoraContaminacionRios.Controllers
{
    public class HomeController : Controller
    {
        private readonly IntegracionService _integracionService;

        public HomeController(IntegracionService integracionService)
        {
            _integracionService = integracionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Resultados(ContaminacionModel model)
        {
            if (ModelState.IsValid)
            {
                // Perform calculations using the integration service
                var resultados = _integracionService.CalcularResultados(model);
                return View(resultados);
            }
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Calcular(ContaminacionModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            // Lógica de cálculo...
            return View("Resultados", resultado);
        }
    }
}