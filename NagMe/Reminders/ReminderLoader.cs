using System.Text.Json;

namespace NagMe.Reminders
{
    public class ReminderLoader
    {
        private List<Reminder> _reminders = new();
        private string? _path = null;
        private static ReminderLoader? _current;
        public IReadOnlyList<Reminder> Reminders => _reminders;
        public bool IsDirty { get; private set; }

        public static ReminderLoader Current
        {
            get
            {
                ArgumentNullException.ThrowIfNull(_current);

                return _current;
            }
        }

        public ReminderLoader(string path)
        {
            LoadReminders(path);
        }

        public static ReminderLoader Initialize(string path)
        {
            _current = new ReminderLoader(path);
            return _current;
        }

        private void LoadReminders(string path)
        {
            _path = path;
            if (File.Exists(path))
            {
                var remindersJsonRaw = File.ReadAllText(path);
                var reminders = JsonSerializer.Deserialize<List<Reminder>>(remindersJsonRaw);
                if(reminders != null)
                {
                    _reminders = reminders;
                    foreach (var reminder in _reminders)
                    {
                        if (reminder.IsEnabled)
                        {
                            reminder.Restart();
                        }
                    }
                }
            }
        }

        public void SaveReminders()
        {
            ArgumentNullException.ThrowIfNull(_path);

            var remindersJsonRaw = JsonSerializer.Serialize(Reminders);
            File.WriteAllText(_path, remindersJsonRaw);

            IsDirty = false;
        }

        public void AddReminder(Reminder reminder)
        {
            _reminders.Add(reminder);
            IsDirty = true;
        }

        public void RemoveReminder(Reminder reminder)
        {
            _reminders.Remove(reminder);
            IsDirty = true;
        }

        public void ClearReminders()
        {
            _reminders.Clear();
            IsDirty = true;
        }

        public void SetReminderEnabledState(
            Reminder reminder,
            bool isEnabled)
        {
            reminder.IsEnabled = isEnabled;
            IsDirty = true;
        }
    }
}
