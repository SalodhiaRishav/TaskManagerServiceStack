using System;
using System.Collections.Generic;
using System.Text;
using BAL.Interfaces;
using ServiceStack;
using UserTaskManger.ServiceModel.RequestDTO;
using UserTaskManger.ServiceModel.ResponseDTO;
using Shared.DTO;

namespace UserTaskManger.ServiceInterface.Services
{
    public class UserService : Service
    {
        IUserBusinessLogic UserBusinessLogic;
        public UserService(IUserBusinessLogic userBusinessLogic)
        {
            UserBusinessLogic = userBusinessLogic;
        }

        public object Get(GetUserByIdRequestDTO request)
        {
            UserDTO user = UserBusinessLogic.GetById(request.id);
            return new GetUserByIdResponseDTO { Result = user };
        }
    }
}
