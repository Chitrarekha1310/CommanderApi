
using  System.ComponentModel.DataAnnotations;

namespace Commander.DTOs
{
    public class CommandUpdateDTO
    {
        //Id is created by database itself
        //public int Id { get; set; }
        [Required]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}