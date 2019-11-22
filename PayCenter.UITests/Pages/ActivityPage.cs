using System;
using System.Linq;

// Aliases Func<AppQuery, AppQuery> with Query
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace PayCenter.UITests.Pages
{
    public class ActivityPage : BasePage
    {
        readonly Query collectionView;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("ActivityPage"),
            iOS = x => x.Marked("ActivityPage")
        };

        public ActivityPage()
        {
            collectionView = x => x.Marked("ActivityCollectionView");
        }

        public ActivityPage RefreshActivityList()
        {
            app.WaitForElement(collectionView);

            var deviceScreenRect = app.Query().FirstOrDefault().Rect;
            var collectionViewRect = app.Query(collectionView).FirstOrDefault().Rect;

            int fromX = Convert.ToInt32(collectionViewRect.Width / 2);
            int fromY = Convert.ToInt32(deviceScreenRect.Height - collectionViewRect.Height);
            int toX = Convert.ToInt32(collectionViewRect.Width / 2);
            int toY = fromY * 5;

            app.Screenshot("Pulling to refresh list");
            app.DragCoordinates(fromX, fromY, toX, toY);

            return this;
        }
    }
}
