using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Domain
{
    public class TaskCategory
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
