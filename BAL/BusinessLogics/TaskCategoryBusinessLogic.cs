using System;
using System.Collections.Generic;
using System.Text;
using BAL.Interfaces;
using DAL.Interfaces;
using Shared;
using Shared.DTO;

namespace BAL.BusinessLogics
{
    public class TaskCategoryBusinessLogic : ITaskCategoryBusinessLogic
    {      
        readonly ITaskCategoryRepository TaskCategoryRepository;
        public TaskCategoryBusinessLogic(ITaskCategoryRepository taskCategoryRepository)
        {
            TaskCategoryRepository = taskCategoryRepository;
        }

        public MessageFormat<TaskCategoryDTO> Add(TaskCategoryDTO taskCategoryDTO)
        {
            try
            {             
                return this.TaskCategoryRepository.Add(taskCategoryDTO);
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public MessageFormat<List<TaskCategoryDTO>> GetAll()
        {
            try
            {
                return this.TaskCategoryRepository.GetAll();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskCategoryDTO> GetById(int id)
        {
            try
            {
                return this.TaskCategoryRepository.GetById(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskCategoryDTO> Delete(int id)
        {
            try
            {
                return this.TaskCategoryRepository.Delete(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskCategoryDTO> Update(TaskCategoryDTO taskCategoryDTO)
        {
            try
            {
                return this.TaskCategoryRepository.Update(taskCategoryDTO);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
