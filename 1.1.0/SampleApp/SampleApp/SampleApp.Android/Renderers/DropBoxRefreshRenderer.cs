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

[assembly: ExportRenderer(typeof(DropBoxRefresh), typeof(DropBoxRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class DropBoxRefreshRenderer : ViewRenderer<DropBoxRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public DropBoxRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.DropBoxHeader mDropBoxHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<DropBoxRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mDropBoxHeader == null)
            {
                mDropBoxHeader = new Com.Scwang.Smartrefresh.Header.DropBoxHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mDropBoxHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}