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

[assembly: ExportRenderer(typeof(HeaderFalsify), typeof(HeaderFalsifyRenderer))]

namespace SampleApp.Droid.Renderers
{
    public class HeaderFalsifyRenderer : ViewRenderer<HeaderFalsify, Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout>
    {
        public HeaderFalsifyRenderer(Context context):base(context){}

        private Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smart.Refresh.Header.FalsifyHeader mFalsifyHeader;
        private Com.Scwang.Smart.Refresh.Header.FalsifyFooter mFalsifyFooter;

        protected override void OnElementChanged(ElementChangedEventArgs<HeaderFalsify> e)
        {
            if (mSmartRefreshLayout == null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout(Context);
            }
            if (mFalsifyHeader == null)
            {
                mFalsifyHeader = new Com.Scwang.Smart.Refresh.Header.FalsifyHeader(Context);
            }
            if (mFalsifyFooter == null)
            {
                mFalsifyFooter = new Com.Scwang.Smart.Refresh.Header.FalsifyFooter(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mFalsifyHeader);
            mSmartRefreshLayout.SetRefreshFooter(mFalsifyFooter);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}