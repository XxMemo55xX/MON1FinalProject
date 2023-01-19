using PueroApp.Models;

namespace PueroApp.Services
{
    public class AppointmentsService : IAppointmentService
    {
        private static List<Appointment> _appointments = new List<Appointment>();

        static AppointmentsService()
        {
            _appointments = new List<Appointment>();
            _appointments.Add(new Appointment
            {
                Title = "New lease document",
                IdAppointment = 1,
                IdClient = 1,
                IdEmployee = 1,
                Date = "12.02.23"
            });
            _appointments.Add(new Appointment
            {
                Title = "Intoduction to the company",
                IdAppointment = 2,
                IdClient = 1,
                IdEmployee = 2,
                Date = "14.02.23"
            });
            _appointments.Add(new Appointment
            {
                Title = "Our Product",
                IdAppointment = 3,
                IdClient = 3,
                IdEmployee = 3,
                Date = "17.03.23"
            });
            _appointments.Add(new Appointment
            {
                Title = "Key Results",
                IdAppointment = 4,
                IdClient = 2,
                IdEmployee = 2,
                Date = "01.07.23"
            });
        }
        public List<Appointment> GetAppointments(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return _appointments;
            }

            return _appointments.Where(e => e.Title == query).ToList();
        }

        public void InsertAppointment(Appointment appointment)
        {
            _appointments.Add(appointment);
        }

        public void RemoveAppointment(AppointmentId appointmentId)
        {
            var recordId = appointmentId.Id;
            var itemToRemove = _appointments.Single(r => r.IdAppointment == recordId);
            _appointments.Remove(itemToRemove);
        }

    }
}
