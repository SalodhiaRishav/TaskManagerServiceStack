using ServiceStack;
using UserTaskMangerAPI.ServiceModel;
using BAL.Interfaces;

namespace UserTaskMangerAPI.ServiceInterface
{

    public class MyServices : Service
    {
        IUserBusinessLogic UserBusinessLogic;
        public MyServices(IUserBusinessLogic userBusinessLogic)
        {
            UserBusinessLogic = userBusinessLogic;
        }
        public object Get(GetUserById request)
        {
            
            return new GetUserByIdResponse { Result = };
        }
    }
}