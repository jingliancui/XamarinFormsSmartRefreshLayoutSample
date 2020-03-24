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

[assembly: ExportRenderer(typeof(BezierRadarRefresh), typeof(BezierRadarRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class BezierRadarRefreshRenderer : ViewRenderer<BezierRadarRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public BezierRadarRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Layout.Header.BezierRadarHeader mBezierRadarHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<BezierRadarRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mBezierRadarHeader == null)
            {
                mBezierRadarHeader = new Com.Scwang.Smartrefresh.Layout.Header.BezierRadarHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mBezierRadarHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}