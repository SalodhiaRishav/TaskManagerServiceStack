using System.Collections.Generic;
using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.User.ResponseDTOs
{
    public class GetAllUsersResponseDTO
    {
        public MessageFormat<List<UserDTO>> Result { get; set; }
    }
}
