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

        public Time(string time)
        {
            string [] newtime = time.Split(':');
            byte[] tabTime = new byte[3]{0,00,00};
            for (int i = 0; i < newtime.Length; i++)
            {
                tabTime[i] = Byte.Parse(newtime[i]);
            }
            this.hour = verify(tabTime[0], 0, 23);
            this.minutes = verify(tabTime[1], 0, 59);
            this.seconds = verify(tabTime[2], 0, 59);

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

        public static bool operator ==(Time t1, Time t2)
        {
            
                if (Time.ReferenceEquals(t1,null))
                {
                    if (Time.ReferenceEquals(t2,null))
                    {
                        return true;
                    }
                    return false;
                }

                return t1.Equals(t2);
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public int CompareTo(Time other)
        {
            var hourComparison = hour.CompareTo(other.hour);
            if (hourComparison != 0) return hourComparison;
            var minutesComparison = minutes.CompareTo(other.minutes);
            if (minutesComparison != 0) return minutesComparison;
            return seconds.CompareTo(other.seconds);
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.hour<t2.hour)
                return true;
            else
            if (t1.minutes<t2.minutes)
                return true;
            else
            if (t1.seconds<t2.seconds)
                return true;
            else
                return false;
        }

        public static bool operator >(Time t1, Time t2)
        {

            if (t1.hour > t2.hour)
                return true;
            else
            if (t1.minutes > t2.minutes)
                return true;
            else
            if (t1.seconds > t2.seconds)
                return true;
            else
                return false;
        }

        public static bool operator <=(Time t1, Time t2)
        {
            if (t1.hour < t2.hour || t1.Equals(t2))
                return true;
            else
            if (t1.minutes < t2.minutes)
                return true;
            else
            if (t1.seconds < t2.seconds)
                return true;
            else
                return false;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            if (t1.hour > t2.hour || t1.Equals(t2))
                return true;
            else
            if (t1.minutes > t2.minutes)
                return true;
            else
            if (t1.seconds > t2.seconds)
                return true;
            else
                return false;
        }
    }
}
