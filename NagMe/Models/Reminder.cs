using NagMe.Enums;

namespace NagMe.Models
{
    public class Reminder
    {
        public string Name { get; set; } = "New Reminder";
        public string Description { get; set; } = "Give your reminder a helpful description here so that you know exactly why you are being nagged.";
        public int Interval { get; set; } = 5;
        public IntervalPeriod Period { get; set; } = IntervalPeriod.Minutes;
    }
}
