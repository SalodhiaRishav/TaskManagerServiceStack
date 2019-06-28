using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;

namespace UserTaskManger.ServiceModel.Task.RequestDTOs
{
    [Route("/task", "GET")]
    public class GetAllTasksRequestDTO : IReturn<GetAllTasksRequestDTO>
    {
      
    }
}
