using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string UserId { get; set; }
    }
}
