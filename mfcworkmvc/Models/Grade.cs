namespace mfcworkmvc.Models
{
    public class Grade
    {
        public int Id { get; set; } 
        public string GrandName { get; set; }

        public string Section { get; set;}


         public ICollection<Student> Students { get; set; } 

    }
}
