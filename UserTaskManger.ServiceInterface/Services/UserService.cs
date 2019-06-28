using System.Collections.Generic;
using BAL.Interfaces;
using ServiceStack;
using UserTaskManger.ServiceModel.RequestDTO.UserRequestDTOs;
using UserTaskManger.ServiceModel.ResponseDTO.UserResponseDTOs;
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
            UserDTO user = UserBusinessLogic.GetById(request.Id);
            return new GetUserByIdResponseDTO { Result = user };
        }

        public object Get(GetAllUsersRequestDTO request) 
        {
            List<UserDTO> users = UserBusinessLogic.GetAll();
            return new GetAllUsersResponseDTO { Result = users };
        }
    }
}
