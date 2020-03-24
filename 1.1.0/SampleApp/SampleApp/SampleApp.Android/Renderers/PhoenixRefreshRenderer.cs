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

[assembly: ExportRenderer(typeof(PhoenixRefresh), typeof(PhoenixRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class PhoenixRefreshRenderer : ViewRenderer<PhoenixRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public PhoenixRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.PhoenixHeader mPhoenixHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<PhoenixRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mPhoenixHeader == null)
            {
                mPhoenixHeader = new Com.Scwang.Smartrefresh.Header.PhoenixHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mPhoenixHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}