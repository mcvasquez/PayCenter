using System;

// Aliases Func<AppQuery, AppQuery> with Query
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace PayCenter.UITests.Pages
{
    public class BalancePage : BasePage
    {
        readonly Query transferFundsButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("BalancePage"),
            iOS = x => x.Marked("BalancePage")
        };

        public BalancePage()
        {
            transferFundsButton = x => x.Marked("TransferFundsButton");
        }

        public void TapTransferFunds()
        {
            app.WaitForElement(transferFundsButton);
            app.Screenshot("Tapping Transfer Funds button");
            app.Tap(transferFundsButton);
        }
    }
}
