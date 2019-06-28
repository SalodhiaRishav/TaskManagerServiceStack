using System.Collections.Generic;
using DAL.Interfaces;
using Shared.DTO;
using BAL.Interfaces;
using System;
using Shared;

namespace BAL
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        readonly IUserRepository UserRepository;
        public UserBusinessLogic(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public MessageFormat<UserDTO> Add(UserDTO userDTO)
        {
            try
            {
                return this.UserRepository.Add(userDTO);
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<List<UserDTO>> GetAll()
        {
            try
            {
                return this.UserRepository.GetAll();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            
        }

        public MessageFormat<UserDTO> GetById(int id)
        {
            try
            {
                return this.UserRepository.GetById(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            
        }

        public MessageFormat<UserDTO> Delete(int id)
        {
            try
            {
                return this.UserRepository.Delete(id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
           
        }

        public MessageFormat<UserDTO> Update(UserDTO userDTO)
        {
            try
            {
                return this.UserRepository.Update(userDTO);
            }
            catch (Exception exception)
            {
                throw exception;
            }
          
        }
    }
}
