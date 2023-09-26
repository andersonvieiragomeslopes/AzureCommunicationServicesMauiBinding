using Com.Azure.Android.Communication.Calling;
using static Android.Media.Session.MediaSession;

namespace AndroidACSTest
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        CallAgent callAgent { get; set; }
        private DeviceManager _deviceManager;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var callOptions = new CallAgentOptions();
            callOptions.SetDisplayName("Azure");
            SetContentView(Resource.Layout.activity_main);
        }
    }
}