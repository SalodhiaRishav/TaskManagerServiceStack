using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using Shared.DTO;

namespace BAL.Interfaces
{
    public interface ITaskCategoryBusinessLogic
    {
     
        MessageFormat<TaskCategoryDTO> Add(TaskCategoryDTO taskCategoryDTO);

        MessageFormat<TaskCategoryDTO> GetById(int id);

        MessageFormat<List<TaskCategoryDTO>> GetAll();

        MessageFormat<TaskCategoryDTO> Delete(int id);

        MessageFormat<TaskCategoryDTO> Update(TaskCategoryDTO taskCategoryDTO);
    }
}
