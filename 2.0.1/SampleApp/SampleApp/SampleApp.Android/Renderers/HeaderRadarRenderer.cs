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

[assembly: ExportRenderer(typeof(HeaderRadar), typeof(HeaderRadarRenderer))]

namespace SampleApp.Droid.Renderers
{
    public class HeaderRadarRenderer : ViewRenderer<HeaderRadar, Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout>
    {
        public HeaderRadarRenderer(Context context):base(context){}

        private Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smart.Refresh.Header.BezierRadarHeader mBezierRadarHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<HeaderRadar> e)
        {
            if (mSmartRefreshLayout == null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout(Context);
            }
            if (mBezierRadarHeader == null)
            {
                mBezierRadarHeader = new Com.Scwang.Smart.Refresh.Header.BezierRadarHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mBezierRadarHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}