using System;
using System.Collections.Generic;
using System.Text;
using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.User.ResponseDTOs
{
    public class CreateUserResponseDTO
    {
        public MessageFormat<UserDTO> Result { get; set; }
    }
}
