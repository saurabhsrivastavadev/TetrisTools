using DotNetUtils.Win32.UserActivity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace TetrisTools.Services
{
    public class UserActivityMonitoringService
    {
        private IUserActivityMonitor UserActivityMonitor =
            new UserActivityMonitor("TetrisTools");

        public Task<UserActivityStats> GetUserActivityStatsAsync(
                                            DateTime statsFrom, DateTime statsTo)
        {
            return Task.FromResult(
                UserActivityMonitor.GetUserActivityStats(statsFrom, statsTo));
        }

        public Task StartUserActivityMonitoring()
        {
            return Task.Run(() => UserActivityMonitor.StartMonitoring());
        }

        public Task StopUserActivityMonitoring()
        {
            return Task.Run(() => UserActivityMonitor.StopMonitoring());
        }
    }
}
