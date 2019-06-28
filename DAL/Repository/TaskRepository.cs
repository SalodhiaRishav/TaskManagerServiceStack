using System;
using System.Collections.Generic;
using DAL.Database;
using Shared.DTO;
using DAL.Interfaces;
using System.Linq;
using Shared;

namespace DAL.Repository
{
    public class TaskRepository:ITaskRepository
    {
        public DatabaseContext DatabaseContext { get; set; }
        public IDatabaseAutomapperConfiguration DatabaseAutomapperConfiguration { get; set; }
        public TaskRepository(DatabaseContext databaseContext,IDatabaseAutomapperConfiguration databaseAutomapperConfiguration)
        {
            DatabaseContext = databaseContext;
            DatabaseAutomapperConfiguration = databaseAutomapperConfiguration;
        }

        public MessageFormat<TaskDTO> Add(TaskDTO taskDTO)
        {
            taskDTO.CreatedOn = DateTime.Now;
            taskDTO.ModifiedOn = DateTime.Now;
            Domain.Task task = DatabaseAutomapperConfiguration.TaskDTOToTask(taskDTO);
            DatabaseContext.Tasks.Add(task);
            try
            {
                DatabaseContext.SaveChanges();
                taskDTO.ID = task.ID;
                MessageFormat<TaskDTO> result = new MessageFormat<TaskDTO>();
                result.Data = taskDTO;
                result.Message = "Added successfully";
                result.Success = true;
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskDTO> Delete(int id)
        {
            MessageFormat<TaskDTO> result = new MessageFormat<TaskDTO>();
            try
            {
                Domain.Task task = this.DatabaseContext.Tasks.Find(id);
                if (task == null)
                {
                    result.Message = "No task found with this id";
                    result.Success = false;
                    return result;
                }
                DatabaseContext.Tasks.Remove(task);
                DatabaseContext.SaveChanges();
                result.Message = "Deleted Successfully";
                result.Success = true;
                return result;
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }


        public MessageFormat<TaskDTO> GetById(int id)
        {
            MessageFormat<TaskDTO> result = new MessageFormat<TaskDTO>();
            try
            {
                Domain.Task task = this.DatabaseContext.Tasks.Find(id);
                if (task == null)
                {
                    result.Message = "No task found with this id";
                    result.Success = false;
                    return result;
                }
                TaskDTO taskDTO = DatabaseAutomapperConfiguration.TaskToTaskDTO(task);
                result.Message = "Retrieved Successfully";
                result.Data = taskDTO;
                result.Success = true;
                return result;
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<TaskDTO> Update(TaskDTO taskDTO)
        {
            MessageFormat<TaskDTO> result = new MessageFormat<TaskDTO>();
            taskDTO.ModifiedOn = DateTime.Now;
            Domain.Task task = DatabaseAutomapperConfiguration.TaskDTOToTask(taskDTO);
            try
            {
                DatabaseContext.Tasks.Update(task);
                DatabaseContext.SaveChanges();
                result.Message = "Updated Successfully";
                result.Data = taskDTO;
                result.Success = true;
                return result;

            }
            catch(Exception exception)
            {
                throw exception;
            }
          
        }

        public MessageFormat<List<TaskDTO>> GetAll()
        {
            MessageFormat<List<TaskDTO>> result = new MessageFormat<List<TaskDTO>>();           
            try
            {
                List<Domain.Task> taskList = this.DatabaseContext.Tasks.ToList();
                if(taskList.Count==0)
                {                               
                    result.Message = "Empty List";                 
                    result.Success = false;
                    return result;
                }
                List<TaskDTO> taskDTOList=this.DatabaseAutomapperConfiguration.TaskListToTaskDTOList(taskList);
                result.Message = "Retrieved Successfully";
                result.Success = true;
                result.Data = taskDTOList;
                return result;
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
