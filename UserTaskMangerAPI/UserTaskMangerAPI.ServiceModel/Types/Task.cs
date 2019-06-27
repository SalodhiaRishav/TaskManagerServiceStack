using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTaskMangerAPI.ServiceModel.Types
{
    public class Task
    {    
        public int ID { get; set; }
      
        public string TaskDomain { get; set; }
        
        public int TimeSpent { get; set; }
        
        public DateTime TaskDate { get; set; }
        
        public int ExpectedTime { get; set; }
        
        public string UserStory { get; set; }
        
        public DateTime ModifiedOn { get; set; }
        
        public DateTime CreatedOn { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

    }
}
