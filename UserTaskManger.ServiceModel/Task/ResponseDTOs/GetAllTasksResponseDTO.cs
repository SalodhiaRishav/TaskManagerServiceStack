using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.Task.ResponseDTOs
{
    public class GetAllTasksResponseDTO
    {
        public MessageFormat<List<TaskDTO>> Result { get; set; }
    }
}
