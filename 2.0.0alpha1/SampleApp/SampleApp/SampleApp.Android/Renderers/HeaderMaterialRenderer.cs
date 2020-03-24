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

[assembly: ExportRenderer(typeof(HeaderMaterial), typeof(HeaderMaterialRenderer))]

namespace SampleApp.Droid.Renderers
{
    public class HeaderMaterialRenderer : ViewRenderer<HeaderMaterial, Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout>
    {
        public HeaderMaterialRenderer(Context context):base(context){}

        private Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smart.Refresh.Header.MaterialHeader mMaterialHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<HeaderMaterial> e)
        {
            if (mSmartRefreshLayout == null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smart.Refresh.Layout.SmartRefreshLayout(Context);
            }
            if (mMaterialHeader == null)
            {
                mMaterialHeader = new Com.Scwang.Smart.Refresh.Header.MaterialHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mMaterialHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}