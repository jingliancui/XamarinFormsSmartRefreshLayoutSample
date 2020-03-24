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

[assembly: ExportRenderer(typeof(StoreHouseRefresh), typeof(StoreHouseRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class StoreHouseRefreshRenderer : ViewRenderer<StoreHouseRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public StoreHouseRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.StoreHouseHeader mStoreHouseHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<StoreHouseRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mStoreHouseHeader == null)
            {
                mStoreHouseHeader = new Com.Scwang.Smartrefresh.Header.StoreHouseHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mStoreHouseHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}