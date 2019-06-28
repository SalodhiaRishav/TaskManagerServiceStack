using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;
using UserTaskManger.ServiceModel.Task.ResponseDTOs;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.Task.RequestDTOs
{
    [Route("/task", "POST")]
    public class CreateTaskRequestDTO : IReturn<CreateTaskRequestDTO>
    {
       public TaskDTO taskDTO { get; set; }
    }
}
