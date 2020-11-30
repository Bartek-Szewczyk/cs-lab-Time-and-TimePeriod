using System;

namespace Time
{
    public struct Time : IEquatable<Time>,IComparable<Time>
    {
        private byte hour, minutes, seconds;
        public readonly byte Hour => hour;
        public readonly byte Minutes => minutes;
        public readonly byte Seconds => seconds;

        public Time (byte hour ,byte minutes = 0, byte seconds = 0)
        {
            this.hour = verify(hour,0, 23);
            this.minutes = verify(minutes,0, 59);
            this.seconds = verify(seconds, 0, 59);

            byte verify(byte value, byte min, byte max) =>
                (value >= min && value <= max) ? value : throw new ArgumentException();

        }

        public override string ToString() => $"{Hour}:{Minutes:D2}:{Seconds:D2}";

        public bool Equals(Time other)
        {
            return hour == other.hour && minutes == other.minutes && seconds == other.seconds;
        }

        public override bool Equals(object obj)
        {
            return obj is Time other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hour, minutes, seconds);
        }

        public int CompareTo(Time other)
        {
            var hourComparison = hour.CompareTo(other.hour);
            if (hourComparison != 0) return hourComparison;
            var minutesComparison = minutes.CompareTo(other.minutes);
            if (minutesComparison != 0) return minutesComparison;
            return seconds.CompareTo(other.seconds);
        }
    }
}
