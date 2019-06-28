using System;
using System.Collections.Generic;
using System.Text;
using BAL.Interfaces;
using ServiceStack;
using UserTaskManger.ServiceModel.Task.RequestDTOs;
using UserTaskManger.ServiceModel.Task.ResponseDTOs;
using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceInterface.Services
{
    public class TaskService : Service
    {
        ITaskBusinessLogic TaskBusinessLogic;
        public TaskService(ITaskBusinessLogic taskBusinessLogic)
        {
             TaskBusinessLogic = taskBusinessLogic;
        }

        public object Post(CreateTaskRequestDTO createTaskRequestDTO)
        {
            try
            {
               MessageFormat<TaskDTO> result=this.TaskBusinessLogic.Add(createTaskRequestDTO.taskDTO);
               return new CreateTaskResponseDTO { Result = result };
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
