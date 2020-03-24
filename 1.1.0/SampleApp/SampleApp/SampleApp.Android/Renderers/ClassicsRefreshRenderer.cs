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

[assembly: ExportRenderer(typeof(ClassicsRefresh), typeof(ClassicsRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class ClassicsRefreshRenderer : ViewRenderer<ClassicsRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public ClassicsRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Layout.Header.ClassicsHeader mClassicsHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<ClassicsRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mClassicsHeader == null)
            {
                mClassicsHeader = new Com.Scwang.Smartrefresh.Layout.Header.ClassicsHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mClassicsHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}