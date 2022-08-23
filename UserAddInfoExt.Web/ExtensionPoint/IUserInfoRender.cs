using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using System.Web.Mvc;

namespace UserAddInfo.Web.ExtensionPoint
{
    [ExtensionPoint]
    public interface IUserInfoRender
    {
        MvcHtmlString Render(HtmlHelper html, IUser user);

    }
}
