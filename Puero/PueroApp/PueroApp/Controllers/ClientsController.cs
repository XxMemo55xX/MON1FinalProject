using Microsoft.AspNetCore.Mvc;
using PueroApp.Models;
using PueroApp.Services;

namespace PueroApp.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public IActionResult Index(string query)
        {
            var list = _clientService.GetClients(query);
            return View(list);
        }
        [HttpGet]
        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateClient(Client newClient)
        {
            _clientService.InsertClient(newClient);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteClient(string query)
        {
            var list = _clientService.GetClients(query);
            return View(list);
        }

        [HttpPost]
        public IActionResult DeleteClient(ClientId clientId)
        {
            _clientService.RemoveClient(clientId);
            return RedirectToAction("Index");
        }
    }
}
