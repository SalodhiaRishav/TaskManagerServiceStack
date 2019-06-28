using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.Task.ResponseDTOs
{
    public class CreateTaskResponseDTO
    {
        public MessageFormat<TaskDTO> Result { get; set; }
    }
}
