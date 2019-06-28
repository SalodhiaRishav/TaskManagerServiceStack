using Shared.DTO;
using BAL.Interfaces;
using DAL.Interfaces;
using System.Collections.Generic;
using System;
using BAL.Validators;
using Shared;
using FluentValidation.Results;

namespace BAL
{
    public class TaskBusinessLogic :ITaskBusinessLogic
    {
        readonly ITaskRepository TaskRepository;
        public TaskBusinessLogic(ITaskRepository taskRepository)
        {
            TaskRepository = taskRepository;
        }

        public MessageFormat<TaskDTO> Add(TaskDTO taskDTO)
        {
            try
            {
                TaskValidator taskValidator = new TaskValidator();
                ValidationResult result = taskValidator.Validate(taskDTO);

                return this.TaskRepository.Add(taskDTO);                
            }
            catch(Exception exception)
            {
                throw exception;
            }
           
        }

        public MessageFormat<List<TaskDTO>> GetAll()
        {
            try
            {
                return this.TaskRepository.GetAll();
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskDTO> GetById(int id)
        {
            try
            {
                return this.TaskRepository.GetById(id);
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskDTO> Delete(int id)
        {
            try
            {
                return this.TaskRepository.Delete(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskDTO> Update(TaskDTO taskDTO)
        {
            try
            {
                return this.TaskRepository.Update(taskDTO);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
