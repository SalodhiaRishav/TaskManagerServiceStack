﻿using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.TaskCategory.ResponseDTOs
{
    public class DeleteTaskCategoryResponseDTO
    {
        public MessageFormat<TaskCategoryDTO> Result { get; set; }
    }
}
