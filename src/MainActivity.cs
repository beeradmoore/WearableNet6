using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Wearable.Activity;

namespace WearableNet6;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : WearableActivity
{
    TextView textView;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        textView = FindViewById<TextView>(Resource.Id.text);
        SetAmbientEnabled();
    }
}