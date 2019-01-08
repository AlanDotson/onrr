using System;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace QEP.ONRR.Web.Helpers
{
    // This is used to create left navigation links that use the proper "selected" css if it is the current page
    public static class NavigationLinkHelper
    {
        public static MvcHtmlString ListItemAction(this HtmlHelper helper, string name, string actionName, string controllerName)
        {
            const string selectedClass ="list-group-item selected";
            const string selectedSubClass = "list-group-item selectedsub";
            const string unselectedClass = "list-group-item";

            var currentControllerName = (string)helper.ViewContext.RouteData.Values["controller"];
            var currentActionName = (string)helper.ViewContext.RouteData.Values["action"];

            // Select the left nav item if it is the current action
            var className = currentControllerName.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase) &&
                        currentActionName.Equals(actionName, StringComparison.CurrentCultureIgnoreCase)
                ? selectedClass
                : unselectedClass;

            // Check for detail pages under the regular action that should select the menu item as well
            if (className == unselectedClass)
            {
                className = currentControllerName.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase) &&
                            currentActionName.StartsWith(actionName.TrimEnd('s'))
                    ? selectedSubClass
                    : unselectedClass;
            }

            var sb = new StringBuilder();
            var url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            sb.AppendFormat("<a href=\"{0}\" class=\"{1}\">{2}</a>", url.Action(actionName, controllerName), className, name);
            return new MvcHtmlString(sb.ToString());
        }
    }
}