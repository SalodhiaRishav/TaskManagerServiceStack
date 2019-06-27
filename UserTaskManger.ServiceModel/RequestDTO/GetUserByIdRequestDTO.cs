using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;
using UserTaskManger.ServiceModel.ResponseDTO;

namespace UserTaskManger.ServiceModel.RequestDTO
{
    [Route("/user/{id}")]
    public class GetUserByIdRequestDTO : IReturn<GetUserByIdResponseDTO>
    {
        public int id { get; set; }
    }
}
