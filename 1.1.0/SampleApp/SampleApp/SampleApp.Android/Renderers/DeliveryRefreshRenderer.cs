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

[assembly: ExportRenderer(typeof(DeliveryRefresh), typeof(DeliveryRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class DeliveryRefreshRenderer:ViewRenderer<DeliveryRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public DeliveryRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.DeliveryHeader mDeliveryHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<DeliveryRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mDeliveryHeader==null)
            {
                mDeliveryHeader = new Com.Scwang.Smartrefresh.Header.DeliveryHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mDeliveryHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}