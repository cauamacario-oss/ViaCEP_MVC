using Microsoft.AspNetCore.Mvc;
using ViaCepMvc.Models;

namespace ViaCepMvc.Controllers
{
    public class EnderecoController : Controller
    {
        // GET: /Endereco
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Endereco/EnviarDados
        [HttpPost]
        public IActionResult EnviarDados(EnderecoViewModel model)
        {
            // O Model Binding do ASP.NET faz a mágica de capturar os campos do HTML e preencher o 'model'
            // Redirecionamos para a View de visualização (Resultado.cshtml) passando o modelo preenchido
            return View("Resultado", model);
        }
    }
}