using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SampleApp.Controls;
using SampleApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HeaderTwoLevel), typeof(HeaderTwoLevelRenderer))]

namespace SampleApp.Droid.Renderers
{
    public class HeaderTwoLevelRenderer : ViewRenderer<HeaderTwoLevel, Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout>
    {
        public HeaderTwoLevelRenderer(Context context):base(context){}

        private Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smart.Refresh.Header.TwoLevelHeader mTwoLevelHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<HeaderTwoLevel> e)
        {
            if (mSmartRefreshLayout == null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout(Context);
            }
            if (mTwoLevelHeader == null)
            {
                mTwoLevelHeader = new Com.Scwang.Smart.Refresh.Header.TwoLevelHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mTwoLevelHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}