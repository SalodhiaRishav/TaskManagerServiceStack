using System.Collections.Generic;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.ResponseDTO.UserResponseDTOs
{
    public class GetAllUsersResponseDTO
    {
        public List<UserDTO> Result { get; set; }
    }
}
