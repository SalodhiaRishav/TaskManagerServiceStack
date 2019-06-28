using ServiceStack;
using UserTaskManger.ServiceModel.ResponseDTO.UserResponseDTOs;

namespace UserTaskManger.ServiceModel.RequestDTO.UserRequestDTOs
{
    [Route("/user/{id}","GET")]
    public class GetUserByIdRequestDTO : IReturn<GetUserByIdResponseDTO>
    {
        public int id { get; set; }
    }
}
