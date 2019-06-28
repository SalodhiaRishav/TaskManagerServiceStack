using ServiceStack;
using Shared.DTO;
using UserTaskManger.ServiceModel.User.ResponseDTOs;

namespace UserTaskManger.ServiceModel.User.RequestDTOs
{
    [Route("/user", "POST")]
    public class CreateUserRequestDTO : IReturn<CreateUserResponseDTO>
    {
        public UserDTO UserDTO { get; set; }
    }
}
