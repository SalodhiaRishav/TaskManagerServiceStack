using ServiceStack;
using UserTaskManger.ServiceModel.ResponseDTO.UserResponseDTOs;

namespace UserTaskManger.ServiceModel.User.RequestDTOs
{
    [Route("/user", "GET")]
    public class CreateUserRequestDTO : IReturn<CreateUserResponseDTO>
    {
    }
}
