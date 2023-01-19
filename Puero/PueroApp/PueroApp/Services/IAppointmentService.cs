using PueroApp.Models;

namespace PueroApp.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAppointments(string query);
        void InsertAppointment(Appointment appointment);
        void RemoveAppointment(AppointmentId appointmentId);
    }
}
