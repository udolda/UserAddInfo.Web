using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using UserAddInfo.Web.ExtensionPoint;
using UserAddInfo.Web.Models;
using UserAddInfo.Web.Service;

namespace UserAddInfo.Web.Components
{
    [Component]
    public class UserProfileInfoRender : IUserInfoRender
    {
        [NotNull]
        public UserInfoService UserTasksInfoService { get; set; }

        public MvcHtmlString Render(HtmlHelper html, IUser user)
        {
            long activeTasksCount = UserTasksInfoService.GetActiveTasksCount(user);

            return html.Partial("InfoPannel", new UserInfoModel
            {
                TasksCount = activeTasksCount
            });
        }

    }
}
