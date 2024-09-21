using NagMe.Enums;

namespace NagMe.Extensions
{
    public static class IntervalPeriodExtensions
    {
        public static TimeSpan CreateTimeSpan(this ShortIntervalPeriod period, int interval)
        {
            switch (period)
            {
                case ShortIntervalPeriod.Seconds:
                    return TimeSpan.FromSeconds(interval);
                case ShortIntervalPeriod.Minutes:
                    return TimeSpan.FromMinutes(interval);
                case ShortIntervalPeriod.Hours:
                    return TimeSpan.FromHours(interval);
                default:
                    throw new ArgumentOutOfRangeException(nameof(period), period, null);
            }
        }

        public static TimeSpan CreateTimeSpan(this LongIntervalPeriod period, int interval)
        {
            switch (period)
            {
                case LongIntervalPeriod.Days:
                    return TimeSpan.FromDays(interval);
                case LongIntervalPeriod.Weeks:
                    return TimeSpan.FromDays(interval * 7);
                default:
                    throw new ArgumentOutOfRangeException(nameof(period), period, null);
            }
        }
    }
}
