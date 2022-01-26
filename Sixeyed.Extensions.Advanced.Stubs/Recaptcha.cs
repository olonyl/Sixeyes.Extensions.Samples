using System;
using System.Web.Mvc;

namespace Recaptcha
{
    public static class RecaptchaExtensions
    {
        public static string GenerateCaptcha(this HtmlHelper html, string id, string theme)
        {
            return String.Format("<div id='{0}'><p>reCAPTCHA goes here, theme: {1}</p></div>", id, theme);
        }
    }

    public class RecaptchaControlMvc
    {
        public class CaptchaValidatorAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.ActionParameters["captchaValid"] = (object)true;
                base.OnActionExecuting(filterContext);
            }
        }
    }
}
