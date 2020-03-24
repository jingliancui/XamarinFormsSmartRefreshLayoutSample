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

[assembly: ExportRenderer(typeof(BezierCircleRefresh), typeof(BezierCircleRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class BezierCircleRefreshRenderer : ViewRenderer<BezierCircleRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public BezierCircleRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.BezierCircleHeader mBezierCircleHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<BezierCircleRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mBezierCircleHeader == null)
            {
                mBezierCircleHeader = new Com.Scwang.Smartrefresh.Header.BezierCircleHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mBezierCircleHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}