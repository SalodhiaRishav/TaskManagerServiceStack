using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using Shared.DTO;

namespace DAL.Interfaces
{
    public interface ITaskCategoryRepository
    {
        MessageFormat<TaskCategoryDTO> Add(TaskCategoryDTO taskCategoryDTO);

        MessageFormat<TaskCategoryDTO> Delete(int id);

        MessageFormat<List<TaskCategoryDTO>> GetAll();

        MessageFormat<TaskCategoryDTO> GetById(int id);

        MessageFormat<TaskCategoryDTO> Update(TaskCategoryDTO taskCategoryDTO);
    }
}
