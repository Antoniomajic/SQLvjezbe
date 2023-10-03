namespace MassageParlor.Models.DTO
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public DateTime? DateAndTime { get; set; }
        public string Customer { get; set; }
        public int MassageNumber { get; set; }
        public int IdCustomer { get; set; }

    }
}
