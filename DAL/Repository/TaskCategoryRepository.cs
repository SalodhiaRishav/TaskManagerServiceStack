using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Database;
using DAL.Domain;
using DAL.Interfaces;
using Shared;
using Shared.DTO;

namespace DAL.Repository
{
    public class TaskCategoryRepository : ITaskCategoryRepository
    {
        public DatabaseContext DatabaseContext { get; set; }
        public IDatabaseAutomapperConfiguration DatabaseAutomapperConfiguration { get; set; }
        public TaskCategoryRepository(DatabaseContext databaseContext, IDatabaseAutomapperConfiguration databaseAutomapperConfiguration)
        {
            DatabaseContext = databaseContext;
            DatabaseAutomapperConfiguration = databaseAutomapperConfiguration;
        }
        public MessageFormat<TaskCategoryDTO> Add(TaskCategoryDTO taskCategoryDTO)
        {
            MessageFormat<TaskCategoryDTO> result = new MessageFormat<TaskCategoryDTO>();
            taskCategoryDTO.CreatedOn = DateTime.Now;
            taskCategoryDTO.ModifiedOn = DateTime.Now;
            TaskCategory taskCategory = DatabaseAutomapperConfiguration.TaskCategoryDTOToTaskCategory(taskCategoryDTO);
            try
            {
                DatabaseContext.TaskCategories.Add(taskCategory);
                DatabaseContext.SaveChanges();
                taskCategoryDTO.ID = taskCategory.ID;
                result.Data = taskCategoryDTO;
                result.Message = "Added successfully";
                result.Success = true;
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskCategoryDTO> Delete(int id)
        {
            MessageFormat<TaskCategoryDTO> result = new MessageFormat<TaskCategoryDTO>();
            try
            {
                Domain.TaskCategory taskCategory = this.DatabaseContext.TaskCategories.Find(id);
                if (taskCategory == null)
                {
                    result.Message = "No taskcategory found with this id";
                    result.Success = false;
                    return result;
                }
                DatabaseContext.TaskCategories.Remove(taskCategory);
                DatabaseContext.SaveChanges();
                result.Message = "Deleted Successfully";
                result.Success = true;
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<List<TaskCategoryDTO>> GetAll()
        {
            MessageFormat<List<TaskCategoryDTO>> result = new MessageFormat<List<TaskCategoryDTO>>();
            try
            {
                List<Domain.TaskCategory> taskCategoryList = this.DatabaseContext.TaskCategories.ToList();
                if (taskCategoryList.Count == 0)
                {
                    result.Message = "Empty List";
                    result.Success = false;
                    return result;
                }
                List<TaskCategoryDTO> taskCategoryDTOList = this.DatabaseAutomapperConfiguration.TaskCategoryListToTaskCategoryDTOList(taskCategoryList);
                result.Message = "Retrieved Successfully";
                result.Success = true;
                result.Data = taskCategoryDTOList;
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskCategoryDTO> GetById(int id)
        {
            MessageFormat<TaskCategoryDTO> result = new MessageFormat<TaskCategoryDTO>();
            try
            {
                Domain.TaskCategory taskCategory = this.DatabaseContext.TaskCategories.Find(id);
                if (taskCategory == null)
                {
                    result.Message = "No task found with this id";
                    result.Success = false;
                    return result;
                }
                TaskCategoryDTO taskCategoryDTO = DatabaseAutomapperConfiguration.TaskCategoryToTaskCategoryDTO(taskCategory);
                result.Message = "Retrieved Successfully";
                result.Data = taskCategoryDTO;
                result.Success = true;
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskCategoryDTO> Update(TaskCategoryDTO taskCategoryDTO)
        {
            MessageFormat<TaskCategoryDTO> result = new MessageFormat<TaskCategoryDTO>();
            taskCategoryDTO.ModifiedOn = DateTime.Now;
            Domain.TaskCategory taskCategory = DatabaseAutomapperConfiguration.TaskCategoryDTOToTaskCategory(taskCategoryDTO);
            try
            {
                DatabaseContext.TaskCategories.Update(taskCategory);
                DatabaseContext.SaveChanges();
                result.Message = "Updated Successfully";
                result.Data = taskCategoryDTO;
                result.Success = true;
                return result;

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        
    }
}
