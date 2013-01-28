using System;
using System.Web.Mvc;

namespace Line3MusicCode.Mvc
{
    public static class ViewHelpers
    {
        public static string ControllerName(this ViewContext source)
        {
            var name = source.RouteData.Values["controller"] as string;
            if (String.IsNullOrWhiteSpace(name)) return null;
            return name;
        }

        public static string ActionName(this ViewContext source)
        {
            var name = source.RouteData.Values["action"] as string;
            if (String.IsNullOrWhiteSpace(name)) return null;
            return name;
        }

        public static bool IsForController(this ViewContext context, string name)
        {
            return context.ControllerName().Equals(name, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsForAction(this ViewContext context, string name)
        {
            return context.ActionName().Equals(name, StringComparison.InvariantCultureIgnoreCase);
        }

    }

}
