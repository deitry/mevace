using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;

namespace mevace.Controllers
{
    public class EmpireController : Controller
    {

        private readonly ILogger<EmpireController> _logger;

        public EmpireController(ILogger<EmpireController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string name = "Ru", int id = 0)
        {
            // Структура запроса: обрати внимание, что id может обрабатываться специально
            // http://localhost:5000/Empire/Index/1?name=Chelovek

            // ViewData["Message"] = $"Hello, this is {name} President speaking";
            // ViewData["NumTimes"] = id;

            return View("Index1", new mevace.Models.EmpireModel(id: id, name: name));
            // return HtmlEncoder.Default.Encode($"Hello, this is {name} President speaking");
        }


    }
}
