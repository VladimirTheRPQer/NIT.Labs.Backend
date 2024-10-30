using System.ComponentModel.DataAnnotations;

namespace StudentService
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int StudentNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime AdmissionDate { get; set; }
        //поступление
    }
}
