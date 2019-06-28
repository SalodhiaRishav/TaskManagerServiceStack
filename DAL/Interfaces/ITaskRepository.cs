using System.Collections.Generic;
using Shared.DTO;
using Shared;

namespace DAL.Interfaces
{
    public interface ITaskRepository
    {
      MessageFormat<TaskDTO> Add(TaskDTO taskDTO);

      MessageFormat<TaskDTO> Delete(int id);

      MessageFormat<List<TaskDTO>> GetAll();

      MessageFormat<TaskDTO> GetById(int id);

      MessageFormat<TaskDTO> Update(TaskDTO taskDTO);
       
    }
}
