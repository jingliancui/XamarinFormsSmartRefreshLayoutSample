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

[assembly: ExportRenderer(typeof(BattleCityRefresh), typeof(BattleCityRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class BattleCityRefreshRenderer : ViewRenderer<BattleCityRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public BattleCityRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.FunGameBattleCityHeader mFunGameBattleCityHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<BattleCityRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mFunGameBattleCityHeader == null)
            {
                mFunGameBattleCityHeader = new Com.Scwang.Smartrefresh.Header.FunGameBattleCityHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mFunGameBattleCityHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}