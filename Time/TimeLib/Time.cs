using System;

namespace Time
{
    public struct Time
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
    }
}
