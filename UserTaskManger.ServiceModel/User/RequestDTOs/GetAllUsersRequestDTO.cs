using ServiceStack;
using UserTaskManger.ServiceModel.ResponseDTO.UserResponseDTOs;

namespace UserTaskManger.ServiceModel.RequestDTO.UserRequestDTOs
{
    [Route("/user","GET")]
    public class GetAllUsersRequestDTO : IReturn<GetAllUsersResponseDTO>
    {
    }
}
