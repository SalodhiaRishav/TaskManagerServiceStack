using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;
using UserTaskManger.ServiceModel.Task.ResponseDTOs;

namespace UserTaskManger.ServiceModel.Task.RequestDTOs
{
    [Route("/task/{Id}","GET")]
    public class GetTaskByIdRequestDTO : IReturn<GetTaskByIdResponseDTO>
    {
        public int Id { get; set; }
    }
}
