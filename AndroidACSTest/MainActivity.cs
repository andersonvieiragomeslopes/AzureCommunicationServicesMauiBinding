using Com.Azure.Android.Communication.Calling;
using Com.Azure.Android.Communication.Common;
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
            var credentials = new CommunicationTokenCredential("eyJhbGciOiJSUzI1NiIsImtpZCI6IjVFODQ4MjE0Qzc3MDczQUU1QzJCREU1Q0NENTQ0ODlEREYyQzRDODQiLCJ4NXQiOiJYb1NDRk1kd2M2NWNLOTVjelZSSW5kOHNUSVEiLCJ0eXAiOiJKV1QifQ.eyJza3lwZWlkIjoiYWNzOjg3NmU2MDE3LTEwMzItNGY3NS05MTE2LWMyNmE3MzhiNWFhZl8wMDAwMDAxYi03MzQwLTJmOGQtM2QzOS04ZTNhMGQwMGNlNTIiLCJzY3AiOjE3OTIsImNzaSI6IjE2OTU3NjMzMDMiLCJleHAiOjE2OTU4NDk3MDMsInJnbiI6ImFtZXIiLCJhY3NTY29wZSI6InZvaXAiLCJyZXNvdXJjZUlkIjoiODc2ZTYwMTctMTAzMi00Zjc1LTkxMTYtYzI2YTczOGI1YWFmIiwicmVzb3VyY2VMb2NhdGlvbiI6InVuaXRlZHN0YXRlcyIsImlhdCI6MTY5NTc2MzMwM30.Q5BWaNDhTuhEbQwYnobdYATPtndT1-VS1eQFW4FEdj7CP5YoAYYhuWMWNl_5ZZF6LBFQLtPb5PxIHP53J6i_kgm5Xj7eTtvvWA79T_hq-1tvy8vAAi8CO-M05kNQhW_mn-K3KENwkVt7ujIQo8-Ps2g2TgH_RZJ7ZbaPfedXRl8doPJCb7Y9GczPu8dWiDCKjPoxXFNK_tK1u-XBZmu-tfivSdLz9k2vlBRt-dXmTtnM0lzTRBQlTXbBoq1NFwlUw4zqVi3R4B9YTtQG_uACOZmtjySaiFfPH_udIGyme52jy7-TYOrlrvMqoyP24SKS3x1ivaalC_iMXPow0kuALQ");
            var callOptions = new CallAgentOptions();
            callOptions.SetDisplayName("Azure");
            SetContentView(Resource.Layout.activity_main);
        }
    }
}