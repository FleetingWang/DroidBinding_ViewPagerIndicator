
using Com.Shizhefei.View.Indicator.Slidebar;

namespace Com.Shizhefei.View.Indicator
{
    public partial class FixedIndicatorView : Android.Widget.LinearLayout, Com.Shizhefei.View.Indicator.IIndicator
    {
        public void SetScrollBar(IScrollBar scrollBar)
        {
            ScrollBar = scrollBar;
        }
    }
}