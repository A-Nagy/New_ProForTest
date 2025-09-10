using Microsoft.AspNetCore.Mvc.Filters;

namespace New_ProForTest.Filters
{
    public class SessionAuthorizeAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userName = context.HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(userName))
            {
                context.HttpContext.Response.Redirect("/Accounts/Login");
            }
            base.OnActionExecuting(context);
        }
    }
}
