namespace Contractor_Claims.Models
{
    public class HoursWorked
    {
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Hours { get; set; }

        // Navigation property
        public Lecturer Lecturer { get; set; }
    }

}
