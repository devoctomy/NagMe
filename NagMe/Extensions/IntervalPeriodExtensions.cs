using NagMe.Enums;

namespace NagMe.Extensions
{
    public static class IntervalPeriodExtensions
    {
        public static TimeSpan CreateTimeSpan(this IntervalPeriod period, int interval)
        {
            switch (period)
            {
                case IntervalPeriod.Seconds:
                    return TimeSpan.FromSeconds(interval);
                case IntervalPeriod.Minutes:
                    return TimeSpan.FromMinutes(interval);
                case IntervalPeriod.Hours:
                    return TimeSpan.FromHours(interval);
                default:
                    throw new ArgumentOutOfRangeException(nameof(period), period, null);
            }
        }
    }
}
