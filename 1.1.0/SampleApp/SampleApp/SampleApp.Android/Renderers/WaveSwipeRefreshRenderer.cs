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

[assembly: ExportRenderer(typeof(WaveSwipeRefresh), typeof(WaveSwipeRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class WaveSwipeRefreshRenderer : ViewRenderer<WaveSwipeRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public WaveSwipeRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.WaveSwipeHeader mWaveSwipeHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<WaveSwipeRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mWaveSwipeHeader == null)
            {
                mWaveSwipeHeader = new Com.Scwang.Smartrefresh.Header.WaveSwipeHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mWaveSwipeHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}