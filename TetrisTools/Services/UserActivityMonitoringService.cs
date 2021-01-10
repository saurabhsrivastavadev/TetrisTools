using DotNetUtils.Win32.UserActivity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace TetrisTools.Services
{
    public class UserActivityMonitoringService
    {
        private IUserActivityMonitor UAM { get; } =
                    UserActivityMonitor.GetInstance("TetrisTools");

        public Task<UserActivityStats> GetUserActivityStatsAsync(
                                            DateTime statsFrom, DateTime statsTo)
        {
            return Task.FromResult(
                UAM.GetUserActivityStats(statsFrom, statsTo));
        }

        public Task StartUserActivityMonitoring()
        {
            return Task.Run(() => UAM.StartMonitoring());
        }

        public Task StopUserActivityMonitoring()
        {
            return Task.Run(() => UAM.StopMonitoring());
        }
    }
}
