using System;
using NUnit.Framework;
using PayCenter.UITests.Pages;
using Xamarin.UITest;

namespace PayCenter.UITests.Tests
{
    public class Tests : BaseTestFixture
    {
        public Tests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void Repl()
        {
            if (TestEnvironment.IsTestCloud)
                Assert.Ignore("Local only");

            app.Repl();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First Screen");
        }

        [Test]
        public void EnterActivityPageAndRefreshList()
        {
            new HomePage()
                .GoToActivity();

            new ActivityPage()
                .RefreshActivityList();
        }

        [Test]
        public void EnterBalancePageAndTransferFunds()
        {
            new HomePage()
                .GoToBalance();

            new BalancePage()
                .TapTransferFunds();
        }

        [Test]
        public void EnterHomePageAndScrollToLastQuickSendUser()
        {
            new HomePage()
                .ScrollToLastUserFromQuickSend();
        }
    }
}
