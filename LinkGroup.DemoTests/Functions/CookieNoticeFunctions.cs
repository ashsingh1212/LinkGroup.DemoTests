using LinkGroup.DemoTests.Extensions;
using LinkGroup.DemoTests.Pages;

namespace LinkGroup.DemoTests.Functions
{
    public class CookieNoticeFunctions
    {
        /// <summary>
        /// Click the Accept button for Tracking Cookies
        /// </summary>
        public static void AcceptTrackingCookies()
        {
            WebElementExtensions.Click(CookieNoticePolicy.AcceptButton);
        }

        /// <summary>
        /// Click the Deny button for Tracking Cookies
        /// </summary>
        public static void DenyTrackingCookies()
        {
            WebElementExtensions.Click(CookieNoticePolicy.DenyButton);
        }

        /// <summary>
        /// Click the Reset button for Tracking Cookies
        /// </summary>
        public static void ResetTrackingCookies()
        {
            WebElementExtensions.Click(CookieNoticePolicy.ResetButton);
        }
    }
}