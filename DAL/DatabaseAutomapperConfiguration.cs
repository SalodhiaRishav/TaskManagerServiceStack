using System.Collections.Generic;
using AutoMapper;
using DAL.Domain;
using Shared.DTO;
using DAL.Interfaces;

namespace DAL
{
    public class DatabaseAutomapperConfiguration:IDatabaseAutomapperConfiguration
    {
        IMapper Mapper;

        public DatabaseAutomapperConfiguration()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>().ReverseMap();           
                cfg.CreateMap<Task, TaskDTO>().ReverseMap();
                cfg.CreateMap<TaskCategory, TaskCategoryDTO>().ReverseMap();
               
            });
            Mapper = config.CreateMapper();

        }

        public UserDTO UserToUserDTO(User user)
        {
            return Mapper.Map<UserDTO>(user);
        }

        public User UserDTOToUser(UserDTO userDTO)
        {
            return Mapper.Map<User>(userDTO);
        }

        public TaskDTO TaskToTaskDTO(Task task)
        {
            return Mapper.Map<TaskDTO>(task);
        }

        public Task TaskDTOToTask(TaskDTO taskDTO)
        {
            return Mapper.Map<Task>(taskDTO);
        }

        public List<User> UserDTOListToUserList(List<UserDTO> usersDTO)
        {
            return Mapper.Map<List<User>>(usersDTO);
        }

        public List<UserDTO> UserListToUserDTOList(List<User> users)
        {
            return Mapper.Map<List<UserDTO>>(users);
        }

        public List<Task> TaskDTOListToTaskList(List<TaskDTO> tasksDTO)
        {
            return Mapper.Map<List<Task>>(tasksDTO);
        }

        public List<TaskDTO> TaskListToTaskDTOList(List<Task> tasks)
        {
            return Mapper.Map<List<TaskDTO>>(tasks);
        }

        public TaskCategoryDTO TaskCategoryToTaskCategoryDTO(TaskCategory taskCategory)
        {
            return Mapper.Map<TaskCategoryDTO>(taskCategory);
        }

        public TaskCategory TaskCategoryDTOToTaskCategory(TaskCategoryDTO taskCategoryDTO)
        {
            return Mapper.Map<TaskCategory>(taskCategoryDTO);
        }

        public List<TaskCategory> TaskCategoryDTOListToTaskCategoryList(List<TaskCategoryDTO> taskCategoryDTOList)
        {
            return Mapper.Map<List<TaskCategory>>(taskCategoryDTOList);
        }

        public List<TaskCategoryDTO> TaskCategoryListToTaskCategoryDTOList(List<TaskCategory> taskCategoryList)
        {
            return Mapper.Map<List<TaskCategoryDTO>>(taskCategoryList);
        }
    }
}
