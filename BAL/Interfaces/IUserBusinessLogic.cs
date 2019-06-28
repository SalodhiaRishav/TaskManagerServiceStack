using System.Collections.Generic;
using Shared;
using Shared.DTO;

namespace BAL.Interfaces
{
    public interface IUserBusinessLogic 
    {
        MessageFormat<UserDTO> Add(UserDTO userDTO);

        MessageFormat<UserDTO> GetById(int id);

        MessageFormat<List<UserDTO>> GetAll();

        MessageFormat<UserDTO> Delete(int id);

        MessageFormat<UserDTO> Update(UserDTO userDTO);
    }
}
