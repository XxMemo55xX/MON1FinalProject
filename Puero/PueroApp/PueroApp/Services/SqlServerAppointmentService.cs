using PueroApp.Models;
using System.Data.SqlClient;

namespace PueroApp.Services
{
    public class SqlServerAppointmentService : IAppointmentService
    {
        public List<Appointment> GetAppointments(string query)
        {
            SqlConnection con;
            return null;
        }

        public void InsertAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }
        public void RemoveAppointment(AppointmentId appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}
