namespace PueroApp.Models
{
    public class Appointment
    {
        public string Title { get; set; }
        public int IdAppointment { get; set; }
        public int IdClient { get; set; }
        public int IdEmployee { get; set; }
        public string Date { get; set; }

    }
    public class AppointmentId
    {
        public int Id { get; set; }
    }
}
