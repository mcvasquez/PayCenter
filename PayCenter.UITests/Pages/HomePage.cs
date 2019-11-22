using System;

// Aliases Func<AppQuery, AppQuery> with Query
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace PayCenter.UITests.Pages
{
    public class HomePage : BasePage
    {
        readonly Query seeDetailsButton;
        readonly Query yourActivityField;
        readonly Query quickSendScrollView;
        readonly Query balanceGrid;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("HomePage"),
            iOS = x => x.Marked("HomePage")
        };

        public HomePage()
        {
            seeDetailsButton = x => x.Marked("SeeDetails");
            yourActivityField = x => x.Marked("YourActivityArea");
            quickSendScrollView = x => x.Marked("QuickSendScrollView");
            balanceGrid = x => x.Marked("BalanceGrid");
        }

        public HomePage ScrollToLastUserFromQuickSend()
        {
            app.ScrollDownTo(quickSendScrollView);
            app.WaitForElement(quickSendScrollView);
            app.SwipeRightToLeft(quickSendScrollView);
            return this;
        }

        public void GoToActivity()
        {
            app.WaitForElement(seeDetailsButton);
            app.Screenshot("Tapping See Details button");
            app.Tap(seeDetailsButton);
        }

        public void GoToBalance()
        {
            app.ScrollDownTo(balanceGrid);
            app.WaitForElement(balanceGrid);
            app.Screenshot("Tapping My Balance section");
            app.Tap(balanceGrid);
        }
    }
}
