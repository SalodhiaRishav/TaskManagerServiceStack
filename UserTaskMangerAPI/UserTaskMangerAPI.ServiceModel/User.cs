using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using UserTaskMangerAPI.ServiceModel.Types;
using Shared.DTO;

namespace UserTaskMangerAPI.ServiceModel
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