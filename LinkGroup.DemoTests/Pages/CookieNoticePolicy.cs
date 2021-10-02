using OpenQA.Selenium;

namespace LinkGroup.DemoTests.Pages
{
    public static class CookieNoticePolicy
    {
        public static By AcceptButton => By.Id("btnAccept");
        public static By DenyButton => By.Id("btnDeny");
        public static By ResetButton => By.Id("btnReset");
    }
}