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

[assembly: ExportRenderer(typeof(WaterDropRefresh), typeof(WaterDropRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class WaterDropRefreshRenderer : ViewRenderer<WaterDropRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public WaterDropRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.WaterDropHeader mWaterDropHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<WaterDropRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mWaterDropHeader == null)
            {
                mWaterDropHeader = new Com.Scwang.Smartrefresh.Header.WaterDropHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mWaterDropHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}