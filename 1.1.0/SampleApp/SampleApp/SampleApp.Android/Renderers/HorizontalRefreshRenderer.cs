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

[assembly: ExportRenderer(typeof(HorizontalRefresh), typeof(HorizontalRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class HorizontalRefreshRenderer : ViewRenderer<HorizontalRefresh, Com.Scwang.Smartrefresh.Horizontal.SmartRefreshHorizontal>
    {
        public HorizontalRefreshRenderer(Context context):base(context)
        {

        }
        
        private Com.Scwang.Smartrefresh.Horizontal.SmartRefreshHorizontal mSmartRefreshHorizontal;

        protected override void OnElementChanged(ElementChangedEventArgs<HorizontalRefresh> e)
        {
            if (mSmartRefreshHorizontal == null)
            {
                mSmartRefreshHorizontal = new Com.Scwang.Smartrefresh.Horizontal.SmartRefreshHorizontal(Context);
            }

            mSmartRefreshHorizontal.SetRefreshHeader(new Com.Scwang.Smartrefresh.Header.MaterialHeader(Context));
            mSmartRefreshHorizontal.SetRefreshFooter(new Com.Scwang.Smartrefresh.Layout.Impl.RefreshFooterWrapper(new Com.Scwang.Smartrefresh.Header.MaterialHeader(Context)), -1, -2);
            
            SetNativeControl(mSmartRefreshHorizontal);
        }
    }
}