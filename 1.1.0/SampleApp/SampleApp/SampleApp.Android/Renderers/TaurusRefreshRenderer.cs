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

[assembly: ExportRenderer(typeof(TaurusRefresh), typeof(TaurusRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class TaurusRefreshRenderer : ViewRenderer<TaurusRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public TaurusRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.TaurusHeader mTaurusHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<TaurusRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mTaurusHeader == null)
            {
                mTaurusHeader = new Com.Scwang.Smartrefresh.Header.TaurusHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mTaurusHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}