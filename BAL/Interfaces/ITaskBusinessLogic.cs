using System.Collections.Generic;
using Shared.DTO;
using Shared;

namespace BAL.Interfaces
{
    public interface ITaskBusinessLogic
    {

        MessageFormat<TaskDTO> Add(TaskDTO taskDTO);

        MessageFormat<TaskDTO> GetById(int id);

        MessageFormat<List<TaskDTO>> GetAll();

        MessageFormat<TaskDTO> Delete(int id);

        MessageFormat<TaskDTO> Update(TaskDTO taskDTO);

    }
}
