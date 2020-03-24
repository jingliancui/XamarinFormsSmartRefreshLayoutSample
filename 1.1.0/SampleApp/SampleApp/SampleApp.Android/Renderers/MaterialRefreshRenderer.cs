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

[assembly: ExportRenderer(typeof(MaterialRefresh), typeof(MaterialRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class MaterialRefreshRenderer : ViewRenderer<MaterialRefresh, Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>
    {
        public MaterialRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.MaterialHeader mMaterialHeader;

        protected override void OnElementChanged(ElementChangedEventArgs<MaterialRefresh> e)
        {
            if (mSmartRefreshLayout==null)
            {
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context);                
            }
            if (mMaterialHeader == null)
            {
                mMaterialHeader = new Com.Scwang.Smartrefresh.Header.MaterialHeader(Context);
            }
            mSmartRefreshLayout.SetRefreshHeader(mMaterialHeader);
            SetNativeControl(mSmartRefreshLayout);
        }
    }
}