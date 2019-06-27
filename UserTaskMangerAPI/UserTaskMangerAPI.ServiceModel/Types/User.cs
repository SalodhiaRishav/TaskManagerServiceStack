using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTaskMangerAPI.ServiceModel.Types
{
    public class User
    {
        public int ID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public DateTime ModifiedOn { get; set; }
        
        public DateTime CreatedOn { get; set; }

        public ICollection<Task> Tasks { get; set; }

    }
}
