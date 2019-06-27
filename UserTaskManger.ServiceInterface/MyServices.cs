using System;
using BAL.Interfaces;
using ServiceStack;
using Shared.DTO;
using UserTaskManger.ServiceModel;

namespace UserTaskManger.ServiceInterface
{
    public class MyServices :Service
    {
        IUserBusinessLogic UserBusinessLogic;
        public MyServices(IUserBusinessLogic userBusinessLogic)
        {
            UserBusinessLogic = userBusinessLogic;
        }
        public object Get(GetUserById request)
        {
            UserDTO user=UserBusinessLogic.GetById(request.id);
            return new GetUserByIdResponse { Result = user};
        }
    }
}
