using System.Collections.Generic;
using BAL.Interfaces;
using ServiceStack;
using UserTaskManger.ServiceModel.User.RequestDTOs;
using UserTaskManger.ServiceModel.User.ResponseDTOs;
using Shared.DTO;
using Shared;
using System;

namespace UserTaskManger.ServiceInterface.Services
{
    public class UserService : Service
    {
        readonly IUserBusinessLogic UserBusinessLogic;
        public UserService(IUserBusinessLogic userBusinessLogic)
        {
            UserBusinessLogic = userBusinessLogic;
        }

        public object Get(GetUserByIdRequestDTO getUserByIdRequestDTO)
        {
            try
            {
                MessageFormat<UserDTO> result = this.UserBusinessLogic.GetById(getUserByIdRequestDTO.Id);
                return new GetUserByIdResponseDTO { Result = result };
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public object Get(GetAllUsersRequestDTO request) 
        {
            try
            {
                MessageFormat<List<UserDTO>> result = this.UserBusinessLogic.GetAll();
                return new GetAllUsersResponseDTO { Result = result };
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public object Delete(DeleteUserRequestDTO deleteUserRequestDTO)
        {
            try
            {
                MessageFormat<UserDTO> result = this.UserBusinessLogic.Delete(deleteUserRequestDTO.Id);
                return new DeleteUserResponseDTO { Result = result };
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public object Post(CreateUserRequestDTO createUserRequestDTO)
        {
            try
            {
                MessageFormat<UserDTO> result = this.UserBusinessLogic.Add(createUserRequestDTO.UserDTO);
                return new CreateUserResponseDTO { Result = result };
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        
    }
}
