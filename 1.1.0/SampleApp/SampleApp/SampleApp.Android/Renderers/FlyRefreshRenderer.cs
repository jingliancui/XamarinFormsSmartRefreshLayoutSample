using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using Java.Interop;
using SampleApp.Controls;
using SampleApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FlyRefresh), typeof(FlyRefreshRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class FlyRefreshRenderer:ViewRenderer<FlyRefresh, Android.Support.Design.Widget.CoordinatorLayout>
    {
        public FlyRefreshRenderer(Context context):base(context)
        {

        }

        private Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout mSmartRefreshLayout;
        private Com.Scwang.Smartrefresh.Header.FlyRefreshHeader mFlyRefreshHeader;
        private Com.Scwang.Smartrefresh.Header.Flyrefresh.MountainSceneView mMountainSceneView;
        private Com.Scwang.Smartrefresh.Header.Flyrefresh.FlyView mFlyView;
        private Android.Support.Design.Widget.CoordinatorLayout mCoordinatorLayout;
        private Android.Support.V7.Widget.RecyclerView mRecyclerView;
        private Android.Support.Design.Widget.FloatingActionButton mFloatingActionButton;

        protected override void OnElementChanged(ElementChangedEventArgs<FlyRefresh> e)
        {
            var x=Inflate(Context, Resource.Layout.FlyLayout, null);
            if (mCoordinatorLayout==null)
            {
                mCoordinatorLayout = x as CoordinatorLayout;
            }

            mMountainSceneView = mCoordinatorLayout.FindViewById<Com.Scwang.Smartrefresh.Header.Flyrefresh.MountainSceneView>(Resource.Id.mountain);
            mFlyView = mCoordinatorLayout.FindViewById<Com.Scwang.Smartrefresh.Header.Flyrefresh.FlyView>(Resource.Id.flyView);
            mFlyRefreshHeader = mCoordinatorLayout.FindViewById<Com.Scwang.Smartrefresh.Header.FlyRefreshHeader>(Resource.Id.flyRefresh);

            mFlyRefreshHeader.SetUp(mMountainSceneView, mFlyView);

            mSmartRefreshLayout = mCoordinatorLayout.FindViewById<Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(Resource.Id.refreshLayout);

            mSmartRefreshLayout.SetReboundInterpolator(new ElasticOutInterpolator());//设置回弹插值器，会带有弹簧震动效果
            mSmartRefreshLayout.SetReboundDuration(800);//设置回弹动画时长

            SetNativeControl(mCoordinatorLayout);
            /*
            if (mCoordinatorLayout == null)
            {
                mCoordinatorLayout = new Android.Support.Design.Widget.CoordinatorLayout(Context)
                {
                    LayoutParameters = new Android.Support.Design.Widget.CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent) ,                   
                };
                mCoordinatorLayout.SetClipChildren(false);
            }

            if (mMountainSceneView == null)
            {
                var dp = 340;
                var density = Context.Resources.DisplayMetrics.Density;
                var dpVal = (int)(dp * density);
                mMountainSceneView = new Com.Scwang.Smartrefresh.Header.Flyrefresh.MountainSceneView(Context)
                {
                    LayoutParameters = new Android.Support.Design.Widget.CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent) { Height= dpVal },
                };
            }

            if (mSmartRefreshLayout == null)
            {
                var dp = 100;
                var density = Context.Resources.DisplayMetrics.Density;
                var dpVal = (int)(dp * density);
                mSmartRefreshLayout = new Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout(Context)
                {
                    LayoutParameters = new Android.Support.Design.Widget.CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
                };
                mSmartRefreshLayout.SetHeaderMaxDragRate(1.5f);
                mSmartRefreshLayout.SetHeaderHeight(dpVal);
                mSmartRefreshLayout.SetReboundDuration(200);
                mSmartRefreshLayout.SetEnableLoadMore(true);                  
            }

            if (mFlyRefreshHeader == null)
            {
                mFlyRefreshHeader = new Com.Scwang.Smartrefresh.Header.FlyRefreshHeader(Context)
                {
                    LayoutParameters = new Android.Support.Design.Widget.CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
                };                
            }

            if (mRecyclerView == null)
            {
                mRecyclerView = new Android.Support.V7.Widget.RecyclerView(Context)
                {
                    Id=55551,
                    LayoutParameters = new Android.Support.Design.Widget.CoordinatorLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent),
                };
                mRecyclerView.OverScrollMode = OverScrollMode.Never;
                var paddingDp = 25;
                var density = Context.Resources.DisplayMetrics.Density;
                var paddingPixel = (int)(paddingDp * density);                
                //mRecyclerView.SetBackgroundColor(Android.Graphics.Color.White);
                mRecyclerView.SetPadding(0, paddingPixel, 0, 0);
                mRecyclerView.SetClipToPadding(false);
            }

            if (mFloatingActionButton == null)
            {
                var dp = 16;
                var density = Context.Resources.DisplayMetrics.Density;
                var dpVal = (int)(dp * density);

                var dp0 = 0;
                var dpVal0 = (int)(dp0 * density);
                mFloatingActionButton = new Android.Support.Design.Widget.FloatingActionButton(Context)
                {
                    Id = 55552,
                    LayoutParameters = new Android.Support.Design.Widget.CoordinatorLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                    {
                        AnchorId = 55551,
                        //AnchorGravity = (int)GravityFlags.Top,
                        //Gravity = (int)GravityFlags.Top,
                        LeftMargin= dpVal,
                        TopMargin= dpVal,
                        RightMargin= dpVal,
                        BottomMargin= dpVal
                    },
                    Elevation = dpVal0
                };
                mFloatingActionButton.SetElevation(dpVal0);
                mFloatingActionButton.Size = FloatingActionButton.SizeNormal;
                mFloatingActionButton.SetForegroundGravity(GravityFlags.Top);
            }

            if (mFlyView == null)
            {
                var dp = 3;
                var density = Context.Resources.DisplayMetrics.Density;
                var dpVal = (int)(dp * density);
                mFlyView = new Com.Scwang.Smartrefresh.Header.Flyrefresh.FlyView(Context)
                {         
                    Id=55553,
                    LayoutParameters = new Android.Support.Design.Widget.CoordinatorLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                    {
                        AnchorId = 55552,
                        //AnchorGravity = (int)GravityFlags.Center,
                        //Gravity= (int)GravityFlags.Center,
                    },
                    Elevation = dpVal,                      
                };
                mFlyView.SetElevation(dpVal);
                mFlyView.SetForegroundGravity(GravityFlags.Center);
            }
            
            mCoordinatorLayout.AddView(mMountainSceneView);

            mCoordinatorLayout.AddView(mSmartRefreshLayout);

            mCoordinatorLayout.AddView(mFloatingActionButton);

            mCoordinatorLayout.AddView(mFlyView);

            mFlyRefreshHeader.SetUp(mMountainSceneView, mFlyView);

            mSmartRefreshLayout.SetRefreshHeader(mFlyRefreshHeader);

            mSmartRefreshLayout.SetRefreshContent(mRecyclerView);
            
            SetNativeControl(mCoordinatorLayout);
            */
        }

    }

    public class ElasticOutInterpolator : Java.Lang.Object, IInterpolator
    {
        public float GetInterpolation(float t)
        {
            if (t == 0) return 0;
            if (t >= 1) return 1;
            float p = .3f;
            float s = p / 4;
            return ((float)Math.Pow(2, -10 * t) * (float)Math.Sin((t - s) * (2 * (float)Math.PI) / p) + 1);
        }
    }
}