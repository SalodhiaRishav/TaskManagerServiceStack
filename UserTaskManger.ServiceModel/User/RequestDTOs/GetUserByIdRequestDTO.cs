using ServiceStack;
using UserTaskManger.ServiceModel.ResponseDTO.UserResponseDTOs;

namespace UserTaskManger.ServiceModel.RequestDTO.UserRequestDTOs
{
    [Route("/user/{Id}","GET")]
    public class GetUserByIdRequestDTO : IReturn<GetUserByIdResponseDTO>
    {
        public int Id { get; set; }
    }
}
