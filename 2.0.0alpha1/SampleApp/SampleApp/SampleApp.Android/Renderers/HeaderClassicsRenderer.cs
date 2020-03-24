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

[assembly: ExportRenderer(typeof(HeaderClassics), typeof(HeaderClassicsRenderer))]

namespace SampleApp.Droid.Renderers
{
    public class HeaderClassicsRenderer:ViewRenderer<HeaderClassics, Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout>
    {
        public HeaderClassicsRenderer(Context context):base(context){}

        private Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smart.Refresh.Header.ClassicsHeader mClassicsHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<HeaderClassics> e)
        {
            if (mSmartRefreshLayout == null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout(Context);
            }
            if (mClassicsHeader == null)
            {
                mClassicsHeader = new Com.Scwang.Smart.Refresh.Header.ClassicsHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mClassicsHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}