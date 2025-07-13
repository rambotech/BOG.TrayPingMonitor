using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BOG.TrayPingMonitor.WinForm.Entity
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class TargetAddress
    {
        [JsonProperty]
        public string IpAddress { get; set; }

        public string DisplayName { get; set; }

        public TimeSpan PingNormalFrequency { get; set; } = TimeSpan.FromSeconds(30);

        public TimeSpan PingFocusedFrequency { get; set; } = TimeSpan.FromSeconds(5);

        public int MissedPingWarningCount { get; set; } = 2;

        public int MissedPingErrorCount { get; set; } = 4;

        public int PingUnrespondedCount { get; set; } = 0;

        public int PingRecoveryCount { get; set; } = 5;

        public DateTime PingUnrespondedFirstTime { get; set; } = DateTime.MinValue;

        public DateTime PingUnrespondedRecentTime { get; set; } = DateTime.MinValue;

        public DateTime NotificationsStfuUntil { get; set; } = DateTime.MinValue;

        public DateTime LastActivity { get; set} = DateTime.MinValue;
    }
}
