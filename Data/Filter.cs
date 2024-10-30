namespace StudentService
{
    public class Filter
    {
        public DateTime? MinAdmissionDate { get; set; }
        public DateTime? MaxAdmissionDate { get; set; }
        public int? MinAge {  get; set; }
        public int? MaxAge { get; set; }
    }
}
