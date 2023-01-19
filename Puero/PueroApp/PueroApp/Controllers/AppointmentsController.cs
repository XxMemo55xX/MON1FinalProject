using Microsoft.AspNetCore.Mvc;
using PueroApp.Models;
using PueroApp.Services;

namespace PueroApp.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult Index(string query)
        {
            var list = _appointmentService.GetAppointments(query);
            return View(list);
        }
        [HttpGet]
        public IActionResult CreateAppointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAppointment(Appointment newAppointment)
        {
            _appointmentService.InsertAppointment(newAppointment);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteAppointment(string query)
        {
            var list = _appointmentService.GetAppointments(query);
            return View(list);
        }

        [HttpPost]
        public IActionResult DeleteAppointment(AppointmentId appointmentId)
        {
            _appointmentService.RemoveAppointment(appointmentId);
            return RedirectToAction("Index");
        }
    }
}
