using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEval.Models
{
    public enum Genre
    {
        Male,
        Female,
    }
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Please Enter a Name")]
        public string Name { get; set; }
        [Required]
        public Genre GenreStudent { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}