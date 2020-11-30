using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Time
{
    public struct TimePeriod : IEquatable<TimePeriod>, IComparable<TimePeriod>
    {
        private long seconds;
        public readonly long Seconds => seconds;
        public TimePeriod(byte hour, byte minutes, byte seconds = 0)
        {
            this.seconds = hour * 3600 + verify(minutes, 0, 59) * 60 + verify(seconds, 0, 59);

            byte verify(byte value, byte min, byte max) =>
                (value >= min && value <= max) ? value : throw new ArgumentException();

        }

        public TimePeriod(long seconds)
        {
            this.seconds = seconds;
        }

        public TimePeriod(string timePeriod)
        {
            string[] newtime = timePeriod.Split(':');
            byte[] tabTime = new byte[3] { 0, 00, 00 };
            for (int i = 0; i < newtime.Length; i++)
            {
                tabTime[i] = Byte.Parse(newtime[i]);
            }
            this.seconds = tabTime[0] * 3600 + verify(tabTime[1], 0, 59) * 60 + verify(tabTime[2], 0, 59);

            byte verify(byte value, byte min, byte max) =>
                (value >= min && value <= max) ? value : throw new ArgumentException();
        }




        public override string ToString() => $"{Seconds / 3600}:{(Seconds / 60)%60:D2}:{Seconds % 60:D2}";


        public bool Equals(TimePeriod other)
        {
            return Seconds == other.Seconds;
        }

        public override bool Equals(object obj)
        {
            return obj is TimePeriod other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Seconds.GetHashCode();
        }

        public static bool operator ==(TimePeriod tp1, TimePeriod tp2)
        {

            if (TimePeriod.ReferenceEquals(tp1, null))
            {
                if (TimePeriod.ReferenceEquals(tp2, null))
                {
                    return true;
                }
                return false;
            }

            return tp1.Equals(tp2);
        }

        public static bool operator !=(TimePeriod tp1, TimePeriod tp2)
        {
            return !(tp1 == tp2);
        }

        public int CompareTo(TimePeriod other)
        {
            return Seconds.CompareTo(other.Seconds);
        }

        public static bool operator <(TimePeriod tp1, TimePeriod tp2)
        {
            if (tp1.Seconds < tp2.Seconds)
                return true;
            return false;
        }

        public static bool operator >(TimePeriod tp1, TimePeriod tp2)
        {
            if (tp1.Seconds > tp2.Seconds)
                return true;
            return false;
        }

        public static bool operator <=(TimePeriod tp1, TimePeriod tp2)
        {
            if (tp1.Seconds < tp2.Seconds || tp1.Equals(tp2))
                return true;
            return false;

        }

        public static bool operator >=(TimePeriod tp1, TimePeriod tp2)
        {
            if (tp1.Seconds > tp2.Seconds || tp1.Equals(tp2))
                return true;
            return false;
        }

        public static TimePeriod operator +(TimePeriod tp1, TimePeriod tp2)
        {
            long ss = tp1.Seconds + tp2.Seconds;

            return new TimePeriod(ss);
        }

        public void TimePeriod_Plus(TimePeriod tp1)
        {
            long ss = Seconds + tp1.Seconds;
            seconds = ss;

        }
    }
}
