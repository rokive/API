using System.ComponentModel.DataAnnotations;


namespace Entity.Models
{
    public class Category :Base
    {
        public Category()
        {

        }
        [Required]
        public string CategoryName { get; set; }
        public string Test { get; set; }
    }
}
