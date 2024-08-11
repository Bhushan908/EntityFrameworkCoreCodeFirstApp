using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCoreCodeFirstApp.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
