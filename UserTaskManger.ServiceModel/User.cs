using System;
using ServiceStack;
using Shared.DTO;

namespace UserTaskManger.ServiceModel
{
    [Route("/user/{id}")]
    public class GetUserById : IReturn<GetUserByIdResponse>
    {
        public int id { get; set; }
    }

    public class GetUserByIdResponse
    {
        public UserDTO Result { get; set; }
    }
}
