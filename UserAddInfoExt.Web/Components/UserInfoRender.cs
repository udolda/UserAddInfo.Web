using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserAddInfo.Web.ExtensionPoint;

namespace UserAddInfo.Web.Components
{
    [Component]
    public class UserInfoRender : IExtensionZone
    {
        public const string ZoneId = "EleWise.ELMA.BPM.Web.Security.Profile.ProfileInfo";

        public bool CanRenderInZone(string zoneId, HtmlHelper html)
        {
            return ZoneId == zoneId;
        }

        public void RenderZone(string zoneId, HtmlHelper html)
        {
            var renderer = ComponentManager.Current.GetExtensionPoints<IUserInfoRender>().FirstOrDefault();
            var model = html.ViewData.Model as UserModel;
            if (model.User != null)
            {
                html.ViewContext.Writer.WriteLine(renderer.Render(html, model.User));
            }
        }

    }
}
