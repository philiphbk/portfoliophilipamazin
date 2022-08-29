using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string JobRole { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserId { get; set; }
    }
}
