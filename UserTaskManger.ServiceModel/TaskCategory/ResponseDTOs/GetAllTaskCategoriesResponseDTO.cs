﻿using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.TaskCategory.ResponseDTOs
{
    public class GetAllTaskCategoriesResponseDTO
    {
        public MessageFormat<List<TaskCategoryDTO>> Result { get; set; }
    }
}
