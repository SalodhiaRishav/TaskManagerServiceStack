using Shared;
using Shared.DTO;

namespace UserTaskManger.ServiceModel.User.ResponseDTOs
{
    public class GetUserByIdResponseDTO
    {
        public MessageFormat<UserDTO> Result { get; set; }
    }
}
