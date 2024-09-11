namespace Contractor_Claims.Models
{
   public class Claim
{
    public int Id { get; set; }
    public required string LecturerId { get; set; }
    public decimal HoursWorked { get; set; }
    public decimal RatePerHour { get; set; }
    public DateTime DateSubmitted { get; set; }
    public string? SupportingDocumentPath { get; set; }
    public required string FilePath { get; set; }

    // Navigation property to link to Lecturer
    public required Lecturer Lecturer { get; set; }
}

}
