namespace Contractor_Claims.Models
{
    public class HoursWorked
    {
        public int Id { get; set; }
        public required string LecturerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Hours { get; set; }

        // Navigation property
        public required Lecturer Lecturer { get; set; }
    }

}
