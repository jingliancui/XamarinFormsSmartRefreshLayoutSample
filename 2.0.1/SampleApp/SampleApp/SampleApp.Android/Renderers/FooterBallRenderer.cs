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

[assembly: ExportRenderer(typeof(FooterBall), typeof(FooterBallRenderer))]

namespace SampleApp.Droid.Renderers
{
    public class FooterBallRenderer : ViewRenderer<FooterBall, Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout>
    {
        public FooterBallRenderer(Context context):base(context){}

        private Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smart.Refresh.Footer.BallPulseFooter mBallPulseFooter;

        protected override void OnElementChanged(ElementChangedEventArgs<FooterBall> e)
        {
            if (mSmartRefreshLayout == null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout(Context);
            }
            if (mBallPulseFooter == null)
            {
                mBallPulseFooter = new Com.Scwang.Smart.Refresh.Footer.BallPulseFooter(Context);
            }
            mSmartRefreshLayout.SetRefreshFooter(mBallPulseFooter);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}