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

[assembly: ExportRenderer(typeof(HitBlockRefresh), typeof(HitBlockRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class HitBlockRefreshRenderer : ViewRenderer<HitBlockRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public HitBlockRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.FunGameHitBlockHeader mFunGameHitBlockHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<HitBlockRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mFunGameHitBlockHeader == null)
            {
                mFunGameHitBlockHeader = new Com.Scwang.Smartrefresh.Header.FunGameHitBlockHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mFunGameHitBlockHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}