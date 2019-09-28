using System.ComponentModel.DataAnnotations;

namespace WebEval.Models
{
    public enum Status
    {
        Approved,
        Reprobate,
    }
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        [Required(ErrorMessage = "Inserte una calificacion")]
        public int Qualification { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public string Name { get; set; }
    }
}