using System.Collections.Generic;
using Shared.DTO;
using Shared;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        MessageFormat<UserDTO> Add(UserDTO userDTO);

        MessageFormat<UserDTO> Delete(int id);

        MessageFormat<List<UserDTO>> GetAll();

        MessageFormat<UserDTO> GetById(int id);

        MessageFormat<UserDTO> Update(UserDTO userDTO);
    }
}
