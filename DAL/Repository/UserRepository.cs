using System.Linq;
using System;
using System.Collections.Generic;
using DAL.Database;
using Shared.DTO;
using DAL.Interfaces;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Shared;

namespace DAL.Repository
{
    public class UserRepository:IUserRepository
    {
        public DatabaseContext DatabaseContext { get; set; }
        public IDatabaseAutomapperConfiguration DatabaseAutomapperConfiguration { get; set; }

        public UserRepository(DatabaseContext databaseContext,IDatabaseAutomapperConfiguration databaseAutomapperConfiguration)
        {
            DatabaseContext = databaseContext;
             DatabaseAutomapperConfiguration = databaseAutomapperConfiguration;
        }

        public MessageFormat<UserDTO> Add(UserDTO userDTO)
        {
            userDTO.CreatedOn = DateTime.Now;
            userDTO.ModifiedOn = DateTime.Now;
            User user = DatabaseAutomapperConfiguration.UserDTOToUser(userDTO);
            MessageFormat<UserDTO> result = new MessageFormat<UserDTO>();
            try
            {
                var userList = DatabaseContext.Users.ToList();
                if(userList.Count!=0)
                {
                    var tempuser=userList.Find(fuser => fuser.Email == user.Email);
                    if (tempuser != null)
                    {
                        result.Message = "Email already exists";
                        result.Success = false;
                        return result;
                    }
                    else
                    {
                        DatabaseContext.Users.Add(user);
                        DatabaseContext.SaveChanges();
                        userDTO.ID = user.ID;
                        result.Data = userDTO;
                        result.Message = "Added successfully";
                        result.Success = true;
                        return result;
                    }
                }               
                else
                {
                    DatabaseContext.Users.Add(user);
                    DatabaseContext.SaveChanges();
                    userDTO.ID = user.ID;
                    result.Data = userDTO;
                    result.Message = "Added successfully";
                    result.Success = true;
                    return result;
                }              
            }
            catch(Exception exception)
            {
                throw exception;
            }      
           

        }

        public MessageFormat<UserDTO> Delete(int id)
        {
            MessageFormat<UserDTO> result = new MessageFormat<UserDTO>();
            try
            {
                User user = this.DatabaseContext.Users.Find(id);
                if (user == null)
                {
                    result.Message = "No task found with this id";
                    result.Success = false;
                    return result;
                }
                DatabaseContext.Users.Remove(user);
                DatabaseContext.SaveChanges();
                result.Message = "Deleted successfully";
                result.Success = true;
                return result;
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        public MessageFormat<List<UserDTO>> GetAll()
        {
            MessageFormat<List<UserDTO>> result = new MessageFormat<List<UserDTO>>();
            try
            {
                List<User> userList = this.DatabaseContext.Users.ToList();
                if(userList.Count==0)
                {
                    result.Message = "Empty List";
                    result.Success = false;
                    return result;
                }
                List<UserDTO> userDTOList = this.DatabaseAutomapperConfiguration.UserListToUserDTOList(userList);
                result.Message = "Retrieved Successfully";
                result.Success = true;
                result.Data = userDTOList;
                return result;
            }
            catch(Exception exception)
            {
                throw exception;
            }
           
        }

        public MessageFormat<UserDTO> GetById(int id)
        {
            MessageFormat<UserDTO> result = new MessageFormat<UserDTO>();
            try
            {
                List<User> users = this.DatabaseContext.Users
                .Include(u => u.Tasks)
                .Where(uu => uu.ID == id).ToList();

                if (users.Count == 0)
                {
                    result.Message = "No task found with this id";
                    result.Success = false;
                    return result;
                }
                User user = users.First();
                UserDTO userDTO = DatabaseAutomapperConfiguration.UserToUserDTO(user);
                result.Message = "Retrieved successfully";
                result.Success = true;
                result.Data = userDTO;
                return result;              
            }
            catch(Exception exception)
            {
                throw exception;
            }
            
        }

        public MessageFormat<UserDTO> Update(UserDTO userDTO)
        {
            MessageFormat<UserDTO> result = new MessageFormat<UserDTO>();
            userDTO.ModifiedOn = DateTime.Now;
            Domain.User user = DatabaseAutomapperConfiguration.UserDTOToUser(userDTO);
            try
            {
                DatabaseContext.Users.Update(user);
                DatabaseContext.SaveChanges();
                result.Message = "Updated Successfully";
                result.Data = userDTO;
                result.Success = true;
                return result;

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
