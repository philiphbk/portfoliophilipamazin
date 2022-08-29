using System.Collections.Generic;
using IdentityManager.Models;

namespace IdentityManager.ViewModels
{
    public class DashBoardViewModel 
    {
        public ICollection<Projects> Projects { get; set; }
        public ICollection<Skills> Skills { get; set; }
        public ICollection<Experience> Experience { get; set; }
    }
}
