using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class TaskCategoryDTO
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
