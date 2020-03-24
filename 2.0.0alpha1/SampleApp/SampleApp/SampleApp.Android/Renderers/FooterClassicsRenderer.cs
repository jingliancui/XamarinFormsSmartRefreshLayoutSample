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

[assembly: ExportRenderer(typeof(FooterClassics), typeof(FooterClassicsRenderer))]

namespace SampleApp.Droid.Renderers
{
    public class FooterClassicsRenderer : ViewRenderer<FooterClassics, Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout>
    {
        public FooterClassicsRenderer(Context context):base(context){}

        private Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smart.Refresh.Footer.ClassicsFooter mClassicsFooter;

        protected override void OnElementChanged(ElementChangedEventArgs<FooterClassics> e)
        {
            if (mSmartRefreshLayout == null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout(Context);
            }
            if (mClassicsFooter == null)
            {
                mClassicsFooter = new Com.Scwang.Smart.Refresh.Footer.ClassicsFooter(Context);
            }
            mSmartRefreshLayout.SetRefreshFooter(mClassicsFooter);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}