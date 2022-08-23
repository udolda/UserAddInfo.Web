using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;

namespace UserAddInfo.Web.Service
{
    [Service]
    public class UserInfoService
    {
        public long GetActiveTasksCount(IUser user)
        {
            return TaskManager.Instance.GetCurrentCount(user);
        }

    }
}
